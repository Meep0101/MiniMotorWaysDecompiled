Shader "Unlit/Dashed Colored" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_DashCount ("Dash Count", Float) = 1
		_DashSpacing ("Dash Spacing", Float) = 0
		_DashSmoothing ("Dash Smoothing", Float) = 0.03
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