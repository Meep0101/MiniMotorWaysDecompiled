Shader "Unlit/Unlit Headlights" {
	Properties {
		[MaterialToggle] _ShouldRenderBeams ("Should Render Beams", Float) = 0
		_HalfBeamWidth ("Half Beam Width", Float) = 0.01
		_BeamLength ("Beam Length", Float) = 0.01
		_CircleOffset ("Circle Offset", Float) = 0.01
		_CircleRadius ("Circle Radius", Float) = 0.01
		_LeftCutPoint ("Left Cut Point", Vector) = (0,0,0,1)
		_RightCutPoint ("Right Cut Point", Vector) = (0,0,0,1)
		_LeftHeadlightPosition ("Left Headlight Position", Vector) = (0,0,0,1)
		_Opacity ("Opacity", Float) = 0.8
		_Intensity ("Intensity", Float) = 1
		_Color ("Main Color", Vector) = (1,1,1,1)
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