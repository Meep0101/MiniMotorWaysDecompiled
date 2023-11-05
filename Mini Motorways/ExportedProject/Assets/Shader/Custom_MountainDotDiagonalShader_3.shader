Shader "Custom/MountainDotDiagonalShader" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_DiagonalThickness ("Diagonal Thickness", Range(0, 1)) = 0.1
		_Spacing ("Spacing", Float) = 1.4
		_Smoothing ("Smoothing", Range(0, 1)) = 0.1
		_DotColor ("Dot Colour", Vector) = (0.5,1,1,1)
		_DiagonalColor ("Diagonal Colour", Vector) = (0.5,1,1,1)
		_DotDiagonalRatio ("Dot:Diagonal Ratio", Range(0, 1)) = 1
		_Offset ("Horizontal Offset", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}