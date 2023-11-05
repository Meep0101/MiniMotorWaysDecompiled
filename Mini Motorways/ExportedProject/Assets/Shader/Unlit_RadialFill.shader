Shader "Unlit/RadialFill" {
	Properties {
		_InnerColor ("Inner Color", Vector) = (1,1,1,1)
		_OuterColor ("Outer Color", Vector) = (1,1,1,1)
		_Alpha ("Alpha", Range(0, 1)) = 1
		_CircleSize ("Circle Size", Range(0, 2)) = 2
		_InnerCircleSize ("Inner Circle Size", Range(0, 2)) = 0
		_CircleFade ("Circle Fade", Range(0, 0.5)) = 0
		_InnerProgress ("Inner Progress", Range(0, 1.1)) = 0
		_OuterProgress ("Outer Progress", Range(0, 1.1)) = 0
		_FillOffset ("Fill Offset", Range(0, 1)) = 0
		_MainTex ("Texture", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}