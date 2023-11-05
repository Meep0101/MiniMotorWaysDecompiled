Shader "Unlit/Unlit_UpgradeIconDiamond" {
	Properties {
		_DiamondSize ("Diamond Size", Range(0, 1)) = 1
		_OuterRoundness ("Outer Roundness", Range(0, 1)) = 0.1
		_InnerRoundness ("Inner Roundness", Range(0, 1)) = 0
		_OutlineSize ("Outline Size", Range(0, 1)) = 0.1
		_CutoutPosition ("Cutout Position", Vector) = (0,0,0,0)
		_CutoutRadius ("Cutout Radius", Range(0, 2)) = 0
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