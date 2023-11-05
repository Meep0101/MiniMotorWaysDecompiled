Shader "Unlit/Unlit_IndicatorEcho" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_Alpha ("Alpha", Range(0, 1)) = 1
		_CircleSize ("Circle Size", Range(0, 2)) = 2
		_RingSize ("Ring Size", Range(0, 1)) = 0.1
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