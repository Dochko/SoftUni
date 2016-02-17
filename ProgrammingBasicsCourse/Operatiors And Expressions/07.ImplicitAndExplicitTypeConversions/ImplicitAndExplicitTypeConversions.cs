using System;

class ImplicitAndExplicitTypeConversions
{
    static void Main()
    {
        //(type) casting

        float heightInMeters = 1.74f; // Explicit conversion
        double maxHeight = heightInMeters; // Implicit

        double minHeight = (double)heightInMeters; // Explicit

        float actualHeight = (float)maxHeight; // Explicit

        //float maxHeightFloat = maxHeight; // Compilation error !
    }
}