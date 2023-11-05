Shader "Unlit/Colored Grid" {
	Properties {
		_GridSpacing ("Grid Spacing", Float) = 6
		_GridOffset ("Grid Offset", Vector) = (0,0,0,0)
		_GridHalfLineThickness ("Grid Half Line Thickness", Float) = 0.005
		_GridSmoothing ("Grid Smoothing", Float) = 0.001
		_BackgroundColor ("Background Colour", Vector) = (1,0.5,1,1)
		_GridColor ("Grid Colour", Vector) = (0.5,1,1,1)
		_DropShadowColor ("Drop Shadow Colour", Vector) = (0,0,0,1)
		_ShadowTex ("Drop Shadow", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
}