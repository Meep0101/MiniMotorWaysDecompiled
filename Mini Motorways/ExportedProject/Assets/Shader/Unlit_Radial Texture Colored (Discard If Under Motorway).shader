Shader "Unlit/Radial Texture Colored (Discard If Under Motorway)" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_DryColor ("Dry Color", Vector) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Progress ("Progress", Range(0, 1.1)) = 0
		_FillOffset ("Fill Offset", Range(0, 1)) = 0
		_CircleFade ("Circle Fade", Range(0, 0.5)) = 0
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