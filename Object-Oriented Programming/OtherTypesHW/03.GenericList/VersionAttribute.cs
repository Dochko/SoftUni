using System;

//This is Problem 4 from the Homework
//Sorry its in Problem 3 and not in another project - copy of this one.


namespace GenericList
{
    [AttributeUsage(
        AttributeTargets.Struct |
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Enum |
        AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            Major = major;
            Minor = minor;
        }

        public int Major { get; set; }
        public int Minor { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}", Major, Minor);
        }
    }
}