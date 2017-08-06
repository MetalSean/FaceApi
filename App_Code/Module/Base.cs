using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FaceApi.Module {
    /// <summary>
    /// Base Function
    /// </summary>
    public class Base
    {

        public const string subscriptionKey = "4b63e96e1ee3405592666c78bf2e319f";
        
        public byte[] GetImageAsByteArray(string imageFilePath)
        {
            System.IO.FileStream fileStream = new System.IO.FileStream(imageFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }
    }

    public class Detect {
        public const string uriBase = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";

        
    }
}
