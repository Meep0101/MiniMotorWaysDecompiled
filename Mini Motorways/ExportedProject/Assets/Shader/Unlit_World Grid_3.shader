Shader "Unlit/World Grid" {
	Properties {
		_GridSpacing ("Grid Spacing", Float) = 10
		_GridHalfLineThickness ("Grid Half Line Thickness", Float) = 0.1
		_GridSmoothing ("Grid Smoothing", Float) = 0.03
		_Color ("Colour", Vector) = (0.5,1,1,1)
		_CityLimitsSpacing ("City Limits Spacing", Float) = 1
		_CityLimitsHalfLineThickness ("City Limits Half Line Thickness", Float) = 0.1
		_CityLimitsSmoothing ("City Limits Smoothing", Float) = 0
		_CityLimitsAlpha ("City Limits Alpha", Float) = 0.8
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a;
		}
		ENDCG
	}
}