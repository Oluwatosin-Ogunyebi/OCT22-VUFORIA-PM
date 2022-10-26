Shader "Unlit/SeeThrough"
{
    SubShader
    {
        Tags { "Queue" = "Transparent+5"} //3005
        
        Pass    
        {Blend Zero One}
    }
}
