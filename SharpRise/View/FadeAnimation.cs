using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SharpRise.View
{
    internal class FadeAnimation
    {
        enum State
        {
            None,
            Waiting,
            Animation,
            Completed
        }

        private State state = State.None;
        private readonly Timer _timer;
        private double _targetOpacity;
        public double OpacityStep { get; set; } = 0.1;
        public int TimerInterval { get; set; } = 20;

        public Form FormProperty { get; set; }

        public event EventHandler AnimationCompleted;

        public FadeAnimation(Form form)
        {
            state = State.Waiting;
            FormProperty = form ?? throw new ArgumentNullException(nameof(form));
            _timer = new Timer { Interval = TimerInterval };
            _timer.Tick += Timer_Tick;
        }

        public void FadeIn()
        {
            state = State.Animation;
            _targetOpacity = 1.0;
            _timer.Start();
        }

        public void FadeOut()
        {
            state = State.Animation;
            _targetOpacity = 0.0;
            _timer.Start();
        }

        public void StopAnimation()
        {
            _timer.Stop();
            state = State.Completed;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(FormProperty.Opacity - _targetOpacity) < OpacityStep)
            {
                FormProperty.Opacity = _targetOpacity;
                _timer.Stop();
                state = State.Completed;
                OnAnimationCompleted();
            }
            else
            {
                FormProperty.Opacity += _targetOpacity > FormProperty.Opacity ? OpacityStep : -OpacityStep;
            }
        }

        private void OnAnimationCompleted()
        {
            AnimationCompleted?.Invoke(this, EventArgs.Empty);
        }

        public async Task FadeInAsync()
        {
            state = State.Animation;
            _targetOpacity = 1.0;
            _timer.Start();

            await Task.Run(() =>
            {
                while (state != State.Completed)
                {
                    Task.Delay(TimerInterval).Wait();
                }
            });
        }
        public async Task FadeOutAsync()
        {
            state = State.Animation;
            _targetOpacity = 0.0;
            _timer.Start();

            await Task.Run(() =>
            {
                while (state != State.Completed)
                {
                    Task.Delay(TimerInterval).Wait();
                }
            });
        }
    }
}