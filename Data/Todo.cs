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
    }
}
