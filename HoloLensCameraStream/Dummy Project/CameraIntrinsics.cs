namespace HoloLensCameraStream
{
    public struct CameraIntrinsics
    {
        public int Width;
        public int Height;
        public float Fx; //focal length x.
        public float Fy; //focal length y.
        public float Cx; //principal point x.
        public float Cy; //principal point y.
        public float K1; //radial distortion coefficient k1.
        public float K2; //radial distortion coefficient k2.
        public float P1; //tangential distortion coefficient p1.
        public float P2; //tangential distortion coefficient p2.
        public float K3; //radial distortion coefficient k3.
    }
}
 