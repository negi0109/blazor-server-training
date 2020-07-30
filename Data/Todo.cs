namespace BlazorTraining.Data
{
    public class Todo
    {
		public enum State {
			Todo,
			Progress,
			Done,
		}
		public string task;
		public State state;
		public Todo(string task, State state = State.Todo){
			this.task = task;
			this.state = state;
		}
		public void change() {
			switch(this.state) {
				case State.Todo:
					this.state = State.Progress;
					break;
				case State.Progress:
					this.state = State.Done;
					break;
				case State.Done:
					this.state = State.Todo;
					break;
			}
		}
    }
}
