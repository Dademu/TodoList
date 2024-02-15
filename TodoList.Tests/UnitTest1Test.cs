using Xunit;
using TodoList;

namespace TodoList.Tests
{
    public class ToDoItemTests
    {
        [Fact]
        public void NewToDoItem_IsNotCompleted()
        {
            // Arrange
            ToDoItem item = new ToDoItem("Buy groceries");

            // Act

            // Assert
            Assert.False(item.IsCompleted);
        }

        [Fact]
        public void CompleteToDoItem_SetsIsCompletedToTrue()
        {
            // Arrange
            ToDoItem item = new ToDoItem("Buy groceries");

            // Act
            item.Complete();

            // Assert
            Assert.True(item.IsCompleted);
        }

        [Fact]
        public void IncompleteToDoItem_SetsIsCompletedToFalse()
        {
            // Arrange
            ToDoItem item = new ToDoItem("Buy groceries");
            item.Complete();

            // Act
            item.Incomplete();

            // Assert
            Assert.False(item.IsCompleted);
        }

        [Fact]
        public void UpdateToDoItem_ChangesDescription()
        {
            // Arrange
            ToDoItem item = new ToDoItem("Buy groceries");

            // Act
            item.UpdateDescription("Buy clothes");

            // Assert
            Assert.Equal("Buy clothes", item.Description);
        }
    }
}