Shader "Unlit/Unlit_UpgradeIconCircleStack_Passive" {
	Properties {
		_CircleSize ("Circle Size", Range(0, 1)) = 1
		_RingSize ("Ring Size", Range(0, 1)) = 1
		_FrontCutoutPosition ("Front Cutout Position", Vector) = (0,0,0,0)
		_FrontCutoutRadius ("Front Cutout Radius", Range(0, 2)) = 0
		_BackCutoutPosition ("Back Cutout Position", Vector) = (0,0,0,0)
		_BackCutoutRadius ("Back Cutout Radius", Range(0, 2)) = 0
		_MainTex ("Main Texture", 2D) = "white" {}
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