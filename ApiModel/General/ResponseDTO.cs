using System;
namespace ApiModel.General
{
    public class ResponseDTO
    {
        public int status { get; set; }
        public string description { get; set; }
        public object objModel { get; set; }

        public ResponseDTO Success(ResponseDTO obj, object objModel)
        {
            obj.description = "Transaction Sucessfully";
            obj.status = 1;
            obj.objModel = objModel;
            return obj;
        }

        public ResponseDTO Failed(ResponseDTO obj, Exception e)
        {
            obj.description = e.Message;
            obj.status = 0;
            return obj;
        }
    }
}
