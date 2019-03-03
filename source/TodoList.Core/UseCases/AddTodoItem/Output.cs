namespace TodoList.Core.UseCases.AddTodoItem {
    using System;

    public sealed class Output {
        public Guid Id { get; }

        public Output (Guid id) {
            Id = id;
        }
    }
}