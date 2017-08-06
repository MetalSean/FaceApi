using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace FaceApi.Infos {

     public static class Base {
        public class point {
            double x { get; set; }
            double y { get; set; }
        }
    }

    /// <summary>
    /// Face 的摘要描述
    /// </summary>
    public class Face
    {
        public string faceId { get; set; }
        public faceRectangleInfo faceRectangle { get; set; }
        public faceLandmarksInfo faceLandmarks { get; set; }
        public faceAttributesInfo faceAttributes { get; set; }

        public class faceRectangleInfo
        {
            public double width { get; set; }
            public double height { get; set; }
            public double left { get; set; }
            public double top { get; set; }
        }

        public class faceLandmarksInfo
        {
            public Base.point pupilLeft { get; set; }
            public Base.point pupilRight { get; set; }
            public Base.point noseTip { get; set; }
            public Base.point mouthLeft { get; set; }
            public Base.point mouthRight { get; set; }
            public Base.point eyebrowLeftOuter { get; set; }
            public Base.point yebrowLeftInner { get; set; }
            public Base.point eyeLeftOuter { get; set; }
            public Base.point eyeLeftTop { get; set; }
            public Base.point eyeLeftBottom { get; set; }
            public Base.point eyeLeftInner { get; set; }
            public Base.point eyebrowRightInner { get; set; }
            public Base.point eyebrowRightOuter { get; set; }
            public Base.point eyeRightInner { get; set; }
            public Base.point eyeRightTop { get; set; }
            public Base.point eyeRightBottom { get; set; }
            public Base.point eyeRightOuter { get; set; }
            public Base.point noseRootLeft { get; set; }
            public Base.point noseRootRight { get; set; }
            public Base.point noseLeftAlarTop { get; set; }
            public Base.point noseRightAlarTop { get; set; }
            public Base.point noseLeftAlarOutTip { get; set; }
            public Base.point noseRightAlarOutTip { get; set; }
            public Base.point upperLipTop { get; set; }
            public Base.point upperLipBottom { get; set; }
            public Base.point underLipTop { get; set; }
            public Base.point underLipBottom { get; set; }
        }

        public class faceAttributesInfo {
            public faceAttributesInfo() {
                accessories = new List<accessoriesInfo>();
            }

            public double age { get; set; }
            public string gender { get; set; }
            public double smile { get; set; }
            public facialHairInfo facialHair { get; set; }
            public string glasses { get; set; }
            public headPostInfo headPost { get; set; }
            public emotionInfo emotion { get; set; }
            public hairInfo hair { get; set; }
            public makeUpInfo makeUp { get; set; }
            public occlusionInfo occlusion { get; set; }
            public List<accessoriesInfo> accessories { get; set; }
            public blurInfo blur { get; set; }
            public exposureInfo exposure { get; set; }
            public noiseInfo noise { get; set; }
            /* class */
            public class facialHairInfo {
                public double moustache { get; set; }
                public double beard { get; set; }
                public double sideburns { get; set; }
            }
            public class headPostInfo {
                public double roll { get; set; }
                public double yaw { get; set; }
                public double pitch { get; set; }
            }
            public class emotionInfo {
                public double anger { get; set; }
                public double contemp { get; set; }
                public double disgust { get; set; }
                public double fear { get; set; }
                public double happiness { get; set; }
                public double neutral { get; set; }
                public double sadness { get; set; }
                public double surprise { get; set; }

            }
            public class hairInfo {
                public hairInfo() {
                    hairColor = new List<hairColorInfo>();
                }
                public double bald { get; set; }
                public string invisible { get; set; }
                public List<hairColorInfo> hairColor { get; set; }
                public class hairColorInfo {
                    public string color { get; set; }
                    public double confidence { get; set; }
                }
            }
            public class makeUpInfo {
                public bool eyeMakeup { get; set; }
                public bool lipMakeup { get; set; }
            }
            public class occlusionInfo {
                public bool foreheadOccluded { get; set; }
                public bool eyeOccluded { get; set; }
                public bool MouthOccluded { get; set; }
            }
            public class accessoriesInfo {
                public string type { get; set; }
                public double confidence { get; set; }
            }
            public class blurInfo {
                public string blurLevel { get; set; }
                public double value { get; set; }
            }
            public class exposureInfo {
                public string exposureLevel { get; set; }
                public double value { get; set; }
            }
            public class noiseInfo {
                public string noiseLevel { get; set; }
                public double value { get; set; }
            }
        }
    }

}