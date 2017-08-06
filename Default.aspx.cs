using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //TODO: 路徑需讀取並上傳至server端
    string fileString = "F:\\Survey\\FaceApi\\FaceApi_Sample\\face_img\\003.jpg";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_Submit_Click(object sender, EventArgs e)
    {
        MakeAnalysisRequest(this.fileString);
    }

    /// <summary>
    /// analys image
    /// </summary>
    /// <param name="imageFilePath"></param>
    void MakeAnalysisRequest(string imageFilePath) {
        FaceApi.Module.Base BaseApi = new FaceApi.Module.Base();
        FaceApi.Module.Detect DetectApi = new FaceApi.Module.Detect();
        using (System.Net.WebClient wc = new System.Net.WebClient()) {

            wc.Headers.Add("Ocp-Apim-Subscription-Key", FaceApi.Module.Base.subscriptionKey);
            wc.Headers.Add("Content-Type", "application/octet-stream");

            // Request parameters. A third optional parameter is "details".
            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses,emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";

            // Assemble the URI for the REST API Call.
            string uri = FaceApi.Module.Detect.uriBase + "?" + requestParameters;
            
            byte[] byteData = BaseApi.GetImageAsByteArray(imageFilePath);

            byte[] result = wc.UploadData(uri, "POST", byteData);
            String s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
            Response.Write(s + "<br />");
            List<FaceApi.Infos.Face> resultFace = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FaceApi.Infos.Face>>(s);
            Response.Write("人數：" + resultFace.Count + "<br />");

            foreach (FaceApi.Infos.Face human in resultFace) {
                Response.Write("   age:" + human.faceAttributes.age + ", sex:" + human.faceAttributes.gender +"<br />");
            }
        }

       

    }

}