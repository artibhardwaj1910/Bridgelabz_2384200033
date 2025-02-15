using System;
namespace TextEditorUndoRedo
{
    // Node representing a state in the text editor
    class TextNode
    {
        public string Text;
        public TextNode Prev;
        public TextNode Next;

        public TextNode(string text)
        {
            Text = text;
            Prev = null;
            Next = null;
        }
    }

    // Doubly Linked List for managing undo/redo functionality
    class TextEditor
    {
        private TextNode head;
        private TextNode current;
        private int maxHistory = 10;
        private int count = 0;

        // Add a new text state (when user types or performs an action)
        public void AddState(string newText)
        {
            TextNode newNode = new TextNode(newText);

            if (head == null)
            {
                head = newNode;
                current = head;
                count = 1;
                return;
            }

            // Remove all redo steps when new action is performed
            current.Next = null;

            // Attach new node at the end
            newNode.Prev = current;
            current.Next = newNode;
            current = newNode;

            // Maintain the history limit
            count++;
            if (count > maxHistory)
            {
                head = head.Next;
                head.Prev = null;
                count--;
            }
        }

        // Undo: Move to the previous state
        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Undo performed.");
            }
            else
            {
                Console.WriteLine("No more undo steps available.");
            }
        }

        // Redo: Move to the next state
        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Redo performed.");
            }
            else
            {
                Console.WriteLine("No more redo steps available.");
            }
        }

        // Display current state of the text
        public void DisplayCurrentState()
        {
            if (current != null)
                Console.WriteLine("Current Text: " + current.Text);
            else
                Console.WriteLine("No text available.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            while (true)
            {
                Console.WriteLine("\nText Editor Undo/Redo");
                Console.WriteLine("1. Type Text (Add State)");
                Console.WriteLine("2. Undo");
                Console.WriteLine("3. Redo");
                Console.WriteLine("4. Display Current Text");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                string text;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter new text: ");
                        text = Console.ReadLine();
                        editor.AddState(text);
                        break;

                    case 2:
                        editor.Undo();
                        break;

                    case 3:
                        editor.Redo();
                        break;

                    case 4:
                        editor.DisplayCurrentState();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}
