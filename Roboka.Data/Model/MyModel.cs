namespace Roboka.Data.Model
{
    /// <summary>
    /// MyModel
    /// </summary>
    public class MyModel
    {
        /// <summary>
        /// Guid id of the model
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Model name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Model realname
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// Model enum
        /// </summary>
        public MyEnum MyEnum { get; set; }
    }

    /// <summary>
    /// MyEnum
    /// </summary>
    public enum MyEnum
    {
        /// <summary>
        /// My Enum1
        /// </summary>
        Enum1,
        /// <summary>
        /// My Enum2
        /// </summary>
        Enum2
    }
}