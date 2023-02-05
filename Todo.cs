namespace minTodoApi
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
        public Todo() { }
        public Todo(Todo todoItem)
        {
            (Id, Name, IsComplete, Secret) = (todoItem.Id, todoItem.Name, todoItem.IsComplete, todoItem.Secret);

        }
    }
}
