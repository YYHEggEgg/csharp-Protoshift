namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public class BasicCodeWriter : IDisposable
    {
        public BasicCodeWriter(string filePath, string codeIndent = "    ")
        {
            codefile_writer = new(filePath);
            codefile_writer.AutoFlush = true;
            CodeIndent = codeIndent;
        }

        StreamWriter codefile_writer;
        int indent_cnt = 0;
        string cur_prefix = string.Empty;
        private bool disposedValue;
        public readonly string CodeIndent;

        /// <summary>
        /// Write a empty line to the code file.
        /// </summary>
        public void WriteLine() => codefile_writer.WriteLine();

        /// <summary>
        /// Write a line with content to the code file.
        /// </summary>
        /// <param name="content">The content written to the next line.</param>
        public void WriteLine(string content)
        {
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(content);
        }

        #region Write Code
        /// <summary>
        /// Write a line with content to the code file. <para/>
        /// This overload supports writing a sub content, or it's to say, split a code line into two line. <para/>
        /// For example, if provide <paramref name="content"/> = "public class", <paramref name="sub_content_1"/> = "ExampleClass", then the following code will be added to the file: <para/>
        /// <code> public class ExampleClass<para/>
        ///       : ExampleBaseClass</code>
        /// </summary>
        /// <param name="content">The content written to the next line.</param>
        /// <param name="sub_content_1">The sub_content written to the next line, with an extra indent.</param>
        public void WriteLine(string content, string sub_content_1)
        {
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(content);
            codefile_writer.Write(CodeIndent);
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(sub_content_1);
        }

        /// <summary>
        /// Write a line with content to the code file. <para/>
        /// This overload supports writing a sub content, or it's to say, split a code line into two line. <para/>
        /// For example, if provide <paramref name="content"/> = "public class", <paramref name="sub_content_1"/> = "ExampleClass", then the following code will be added to the file: <para/>
        /// <code> public class ExampleClass<para/>
        ///       : ExampleBaseClass</code>
        /// </summary>
        /// <param name="content">The content written to the next line.</param>
        /// <param name="sub_content_1">The sub_content written to the next line, with an extra indent.</param>
        /// <param name="sub_content_2">The sub_content written to the next line, with an extra indent.</param>
        public void WriteLine(string content, string sub_content_1, string sub_content_2)
        {
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(content);
            codefile_writer.Write(CodeIndent);
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(sub_content_1);
            codefile_writer.Write(CodeIndent);
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(sub_content_2);
        }

        /// <summary>
        /// Write a line with content to the code file. <para/>
        /// This overload supports writing a sub content, or it's to say, split a code line into two line. <para/>
        /// For example, if provide <paramref name="content"/> = "public class", <paramref name="sub_content_1"/> = "ExampleClass", then the following code will be added to the file: <para/>
        /// <code> public class ExampleClass<para/>
        ///       : ExampleBaseClass</code>
        /// </summary>
        /// <param name="content">The content written to the next line.</param>
        /// <param name="sub_content_1">The sub_content written to the next line, with an extra indent.</param>
        /// <param name="sub_content_2">The sub_content written to the next line, with an extra indent.</param>
        /// <param name="sub_content_3">The sub_content written to the next line, with an extra indent.</param>
        public void WriteLine(string content, string sub_content_1, string sub_content_2, string sub_content_3)
        {
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(content);
            codefile_writer.Write(CodeIndent);
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(sub_content_1);
            codefile_writer.Write(CodeIndent);
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(sub_content_2);
            codefile_writer.Write(CodeIndent);
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(sub_content_3);
        }

        /// <summary>
        /// Write a line with content to the code file. <para/>
        /// This overload supports writing a sub content, or it's to say, split a code line into two line. <para/>
        /// For example, if provide <paramref name="content"/> = "public class", <paramref name="sub_content_1"/> = "ExampleClass", then the following code will be added to the file: <para/>
        /// <code> public class ExampleClass<para/>
        ///       : ExampleBaseClass</code>
        /// </summary>
        /// <param name="content">The content written to the next line.</param>
        /// <param name="sub_contents_enumerable">Multiple sub_contents written to the next line. Each will be written with an extra indent.</param>
        public void WriteLine(string content, IEnumerable<string> sub_contents_enumerable)
        {
            codefile_writer.Write(cur_prefix);
            codefile_writer.WriteLine(content);
            foreach (var sub_content in sub_contents_enumerable)
            {
                codefile_writer.Write(CodeIndent);
                codefile_writer.Write(cur_prefix);
                codefile_writer.WriteLine(sub_content);
            }
        }

        /// <summary>
        /// Write a line with content to the code file. <para/>
        /// This overload supports writing a sub content, or it's to say, split a code line into two line. <para/>
        /// For example, if provide <paramref name="content"/> = "public class", <paramref name="sub_content_1"/> = "ExampleClass", then the following code will be added to the file: <para/>
        /// <code> public class ExampleClass<para/>
        ///       : ExampleBaseClass</code>
        /// </summary>
        /// <param name="content">The content written to the next line.</param>
        /// <param name="sub_contents">Multiple sub_contents written to the next line. Each will be written with an extra indent.</param>
        public void WriteLine(string content, params string[] sub_contents) 
            => WriteLine(content, sub_contents_enumerable: sub_contents);
        #endregion

        #region Indent Manage
        /// <summary>
        /// Write a <c>{</c> line and increase the indent of the following codes by 1.
        /// </summary>
        public void EnterCodeRegion()
        {
            WriteLine("{");
            AddIndent();
        }
        
        /// <summary>
        /// Decrease the indent of the following codes by 1 and write a <c>}</c> line.
        /// </summary>
        /// <exception cref="InvalidOperationException">The instance currently don't have any indent when writing code.</exception>
        public void ExitCodeRegion()
        {
            RemoveIndent();
            WriteLine("}");
        }
        
        /// <summary>
        /// Only increase the indent of the following codes by 1.
        /// </summary>
        public void AddIndent()
        {
            indent_cnt++;
            cur_prefix += CodeIndent;
        }

        /// <summary>
        /// Only decrease the indent of the following codes by 1.
        /// </summary>
        /// <exception cref="InvalidOperationException">The instance currently don't have any indent when writing code.</exception>
        public void RemoveIndent()
        {
            if (indent_cnt <= 0)
                throw new InvalidOperationException("The instance currently don't have any indent when writing code.");
            indent_cnt--;
            cur_prefix = cur_prefix.Substring(0, cur_prefix.Length - CodeIndent.Length);
        }
        #endregion

        #region IDisposable support
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                codefile_writer.Dispose();
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BasicCodeWriter()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}