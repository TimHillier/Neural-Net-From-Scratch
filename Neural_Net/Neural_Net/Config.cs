using System;
namespace Neural_Net
{
    class Config
    {

        /**
         Important Data
         **/
        private int Input_Dimension;    //number of input dimensions
        private int Output_Dimension;   //number of output dimensions
        private float LearningRate;     //learning rate for grad descent
        private float Strength;         //regulazation strength




        public void Configure(int _inputDim, int _outputDim, float _learningRate, float _strength)
        {
            Set_In_Dim(_inputDim);
            Set_Out_Dim(_outputDim);
            Set_Strength(_learningRate);
            Set_Learning_Rate(_strength);
        }

        /**
            Setters
         **/
        public void Set_In_Dim(int _inputDim)
        {
            Input_Dimension = _inputDim; 

        }
        public void Set_Out_Dim(int _outputDim)
        {
            Output_Dimension = _outputDim; 
        }
        public void Set_Learning_Rate(float _learningRate)
        {
            LearningRate = _learningRate; 
        }
        public void Set_Strength(float _strength)
        {
            Strength = _strength; 
        }
        /**
            Getters
         **/
        public int Get_In_Dim()
        {
            return Input_Dimension; 
        }
        public int Get_Out_Dim()
        {
            return Output_Dimension;
        }
        public float Get_LearningRate()
        {
            return LearningRate; 
        }
        public float Get_Strength()
        {
            return Strength; 
        }



    }
}

