//using System;

//namespace Seterlund.CodeGuard.Internals
//{
//    /// <summary>
//    /// Holds the argument to check
//    /// </summary>
//    /// <typeparam name="T">
//    /// The argument type
//    /// </typeparam>
//    public class ReflectionValidator<T> : ArgBase<T>
//    {
//        private Func<T> argument;

//        public override void ArgumentMessage(string message)
//        {
//            ExceptionHelper.ThrowArgumentException(this, message);
//        }

//        public override void ArgumentNullMessage()
//        {
//            ExceptionHelper.ThrowArgumentNullException(this);
//        }

//        public override void arg.Message.SetArgumentOutRange()
//        {
//            ExceptionHelper.ThrowArgumentOutOfRangeException(this);
//        }

//        /// <summary>
//        /// Initializes a new instance of the <see cref="ReflectionReflectionValidator{T}"/> class.
//        /// </summary>
//        /// <param name="argument">
//        /// The argument.
//        /// </param>
//        public ReflectionValidator(Func<T> argument)
//        {
//            this.argument = argument;
//        }

//        /// <summary>
//        /// Gets the name of the argument 
//        /// </summary>
//        /// <returns>
//        /// The name of the field og class
//        /// </returns>
//        private string GetFieldName()
//        {
//            string fieldName = "Unknown";
//            try
//            {
//                // get IL code behind the delegate
//                var il = this.argument.Method.GetMethodBody().GetILAsByteArray();

//                // bytes 2-6 represent the field handle
//                var fieldHandle = BitConverter.ToInt32(il, 2);

//                // resolve the handle
//                var field = this.argument.Target.GetType().Module.ResolveField(fieldHandle);
//                fieldName = field.Name;
//            }
//            catch
//            {
//                // Swallow exception
//            }

//            return fieldName;
//        }

//    }
//}