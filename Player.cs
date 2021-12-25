using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace Task5
{
    public abstract class Player : ITechnic
    {
        public Player(int volume, string modelName)
        {
            this.Volume = volume;
            this.ModelName = modelName;
        }
        public string ModelName { get; set; }

        private State state = State.STOPPED;
        public State State { get { return state; } }
        
        public int Volume { get; set; }
        public void ChangeState(State state)
        {
            this.state = state;
        }

        public virtual void Play()
        {
            ChangeState(State.STARTED);
        }

        public void Pause()
        {
            ChangeState(State.PAUSED);
        }

        public void Stop()
        {
            ChangeState(State.STOPPED);
        }

        public virtual Dictionary<string,object> GetParameters()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("Громкость", this.Volume);
            parameters.Add("Название модели", this.ModelName);
            parameters.Add("Состояние", this.State);
            return parameters;
        }
    }
}
