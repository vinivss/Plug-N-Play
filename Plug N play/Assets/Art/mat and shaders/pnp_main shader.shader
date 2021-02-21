// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:34249,y:32670,varname:node_2865,prsc:2|emission-7581-OUT;n:type:ShaderForge.SFN_NormalVector,id:7660,x:30292,y:33068,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:757,x:30548,y:33017,varname:node_757,prsc:2,dt:0|A-8289-OUT,B-7660-OUT;n:type:ShaderForge.SFN_ViewVector,id:7290,x:30646,y:32702,varname:node_7290,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7248,x:30877,y:32702,varname:node_7248,prsc:2|A-7290-OUT,B-2461-OUT;n:type:ShaderForge.SFN_Vector1,id:2461,x:30646,y:32863,varname:node_2461,prsc:2,v1:-1;n:type:ShaderForge.SFN_Dot,id:5560,x:31091,y:32594,varname:node_5560,prsc:2,dt:0|A-8289-OUT,B-7248-OUT;n:type:ShaderForge.SFN_LightVector,id:8289,x:30166,y:32855,varname:node_8289,prsc:2;n:type:ShaderForge.SFN_Add,id:5724,x:31280,y:32594,varname:node_5724,prsc:2|A-5560-OUT,B-1522-OUT;n:type:ShaderForge.SFN_Vector1,id:1522,x:31280,y:32733,varname:node_1522,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Add,id:300,x:30739,y:33017,varname:node_300,prsc:2|A-757-OUT,B-1694-OUT;n:type:ShaderForge.SFN_Vector1,id:1694,x:30739,y:33162,varname:node_1694,prsc:2,v1:-0.3;n:type:ShaderForge.SFN_Multiply,id:1890,x:30940,y:33017,varname:node_1890,prsc:2|A-300-OUT,B-46-OUT;n:type:ShaderForge.SFN_Vector1,id:46,x:30940,y:33162,varname:node_46,prsc:2,v1:4;n:type:ShaderForge.SFN_Add,id:4774,x:31280,y:32950,varname:node_4774,prsc:2|A-5724-OUT,B-1890-OUT;n:type:ShaderForge.SFN_Multiply,id:9884,x:31472,y:32950,varname:node_9884,prsc:2|A-4774-OUT,B-702-OUT;n:type:ShaderForge.SFN_Vector1,id:702,x:31472,y:33081,varname:node_702,prsc:2,v1:-1;n:type:ShaderForge.SFN_Clamp,id:6113,x:31689,y:32950,varname:node_6113,prsc:2|IN-9884-OUT,MIN-843-OUT,MAX-3706-OUT;n:type:ShaderForge.SFN_Vector1,id:843,x:31689,y:33093,varname:node_843,prsc:2,v1:0.0001;n:type:ShaderForge.SFN_Vector1,id:3706,x:31689,y:33144,varname:node_3706,prsc:2,v1:1.1;n:type:ShaderForge.SFN_Fresnel,id:750,x:31689,y:33247,varname:node_750,prsc:2|EXP-5327-OUT;n:type:ShaderForge.SFN_Vector1,id:5327,x:31502,y:33247,varname:node_5327,prsc:2,v1:8;n:type:ShaderForge.SFN_Step,id:6971,x:31977,y:33098,cmnt:backlighting always behind,varname:node_6971,prsc:2|A-6113-OUT,B-750-OUT;n:type:ShaderForge.SFN_Color,id:1002,x:32051,y:33335,ptovrint:False,ptlb:thick backlight blend amount,ptin:_thickbacklightblendamount,cmnt:grey color makes it blend into tex ,varname:node_2246,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.05882353,c2:0.05882353,c3:0.05882353,c4:1;n:type:ShaderForge.SFN_Multiply,id:6152,x:32406,y:33019,cmnt:DONE backlight,varname:node_6152,prsc:2|A-6971-OUT,B-1002-RGB;n:type:ShaderForge.SFN_Tex2d,id:5374,x:32304,y:32475,ptovrint:False,ptlb:main tex,ptin:_maintex,varname:node_9145,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_LightVector,id:1527,x:31682,y:32235,varname:node_1527,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:475,x:31682,y:32366,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:94,x:31885,y:32235,varname:node_94,prsc:2,dt:0|A-1527-OUT,B-475-OUT;n:type:ShaderForge.SFN_Multiply,id:5126,x:31885,y:32475,cmnt:scaling and scooting the og values to zero to one,varname:node_5126,prsc:2|A-7436-OUT,B-94-OUT;n:type:ShaderForge.SFN_Vector1,id:7436,x:31885,y:32410,varname:node_7436,prsc:2,v1:0.49;n:type:ShaderForge.SFN_Add,id:3710,x:32064,y:32475,varname:node_3710,prsc:2|A-4589-OUT,B-5126-OUT;n:type:ShaderForge.SFN_Vector1,id:4589,x:32064,y:32410,varname:node_4589,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:4081,x:32079,y:32711,ptovrint:False,ptlb:ramp tex,ptin:_ramptex,varname:_ramp_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a8f5ec4c1352c9f439d504ad61bfadd3,ntxv:0,isnm:False|UVIN-2845-OUT;n:type:ShaderForge.SFN_Append,id:2845,x:31736,y:32629,cmnt:reading ramp horiztonally,varname:node_2845,prsc:2|A-3710-OUT,B-5976-OUT;n:type:ShaderForge.SFN_Vector1,id:5976,x:31736,y:32761,varname:node_5976,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:7693,x:32517,y:32638,cmnt:DONE ramp based cel shader,varname:node_7693,prsc:2|A-5374-RGB,B-4081-RGB;n:type:ShaderForge.SFN_Add,id:7139,x:32911,y:32812,varname:node_7139,prsc:2|A-7693-OUT,B-6152-OUT;n:type:ShaderForge.SFN_Fresnel,id:2194,x:32500,y:32150,varname:node_2194,prsc:2|EXP-7444-OUT;n:type:ShaderForge.SFN_LightVector,id:6298,x:32165,y:31747,varname:node_6298,prsc:2;n:type:ShaderForge.SFN_ViewVector,id:852,x:32165,y:31878,varname:node_852,prsc:2;n:type:ShaderForge.SFN_Dot,id:4768,x:32350,y:31747,varname:node_4768,prsc:2,dt:0|A-6298-OUT,B-852-OUT;n:type:ShaderForge.SFN_Add,id:9975,x:32552,y:31747,varname:node_9975,prsc:2|A-4768-OUT,B-2149-OUT;n:type:ShaderForge.SFN_Vector1,id:2149,x:32552,y:31687,varname:node_2149,prsc:2,v1:-0.6;n:type:ShaderForge.SFN_Clamp01,id:3096,x:32740,y:31747,varname:node_3096,prsc:2|IN-9975-OUT;n:type:ShaderForge.SFN_Multiply,id:6435,x:32977,y:31807,varname:node_6435,prsc:2|A-3096-OUT,B-1730-OUT;n:type:ShaderForge.SFN_OneMinus,id:1496,x:33156,y:31807,varname:node_1496,prsc:2|IN-6435-OUT;n:type:ShaderForge.SFN_Add,id:6443,x:33023,y:31977,varname:node_6443,prsc:2|A-1496-OUT,B-8370-OUT;n:type:ShaderForge.SFN_Vector1,id:8370,x:33023,y:32108,varname:node_8370,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Step,id:5360,x:32838,y:32275,varname:node_5360,prsc:2|A-6443-OUT,B-2194-OUT;n:type:ShaderForge.SFN_Multiply,id:3886,x:32867,y:32457,cmnt:DONE subtle rim lighting on opposite sides and bottoms of things,varname:node_3886,prsc:2|A-5360-OUT,B-271-RGB;n:type:ShaderForge.SFN_Color,id:271,x:32591,y:32370,ptovrint:False,ptlb:subtle edge light blending amount,ptin:_subtleedgelightblendingamount,varname:node_271,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3584906,c2:0.3584906,c3:0.3584906,c4:1;n:type:ShaderForge.SFN_Add,id:9087,x:33234,y:32654,varname:node_9087,prsc:2|A-3886-OUT,B-7139-OUT;n:type:ShaderForge.SFN_Fresnel,id:8737,x:33931,y:34189,varname:node_8737,prsc:2|EXP-6272-OUT;n:type:ShaderForge.SFN_Smoothstep,id:6142,x:34151,y:34022,cmnt:DONE bright rim light,varname:node_6142,prsc:2|A-5579-OUT,B-9627-OUT,V-8737-OUT;n:type:ShaderForge.SFN_Add,id:8656,x:33545,y:32833,varname:node_8656,prsc:2|A-9087-OUT,B-7923-OUT;n:type:ShaderForge.SFN_Vector1,id:6272,x:33645,y:34225,varname:node_6272,prsc:2,v1:50;n:type:ShaderForge.SFN_Vector1,id:7444,x:32476,y:32073,varname:node_7444,prsc:2,v1:10;n:type:ShaderForge.SFN_Vector1,id:1730,x:32756,y:31921,varname:node_1730,prsc:2,v1:2;n:type:ShaderForge.SFN_Vector1,id:9627,x:33931,y:34114,varname:node_9627,prsc:2,v1:0.06;n:type:ShaderForge.SFN_Vector1,id:5579,x:33931,y:34056,varname:node_5579,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Fresnel,id:8299,x:33502,y:33091,varname:node_8299,prsc:2|EXP-1749-OUT;n:type:ShaderForge.SFN_Vector1,id:1749,x:33326,y:33179,varname:node_1749,prsc:2,v1:1;n:type:ShaderForge.SFN_Add,id:7581,x:33847,y:32895,varname:node_7581,prsc:2|A-8656-OUT,B-2039-OUT;n:type:ShaderForge.SFN_Color,id:2762,x:33502,y:33262,ptovrint:False,ptlb:faint glow around edges blend amount,ptin:_faintglowaroundedgesblendamount,varname:node_2762,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.07843138,c3:0.07843138,c4:1;n:type:ShaderForge.SFN_Multiply,id:2039,x:33761,y:33174,cmnt:DONE sliiight glow around edges,varname:node_2039,prsc:2|A-8299-OUT,B-2762-RGB;n:type:ShaderForge.SFN_NormalVector,id:5942,x:30706,y:34115,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:7550,x:30962,y:34064,varname:node_7550,prsc:2,dt:0|A-7622-OUT,B-5942-OUT;n:type:ShaderForge.SFN_ViewVector,id:1839,x:31060,y:33749,varname:node_1839,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6451,x:31291,y:33749,varname:node_6451,prsc:2|A-1839-OUT,B-2317-OUT;n:type:ShaderForge.SFN_Vector1,id:2317,x:31060,y:33910,varname:node_2317,prsc:2,v1:-1;n:type:ShaderForge.SFN_Dot,id:17,x:31505,y:33641,varname:node_17,prsc:2,dt:0|A-7622-OUT,B-6451-OUT;n:type:ShaderForge.SFN_LightVector,id:7622,x:30580,y:33902,varname:node_7622,prsc:2;n:type:ShaderForge.SFN_Add,id:9587,x:31694,y:33641,varname:node_9587,prsc:2|A-17-OUT,B-2367-OUT;n:type:ShaderForge.SFN_Vector1,id:2367,x:31694,y:33780,varname:node_2367,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Add,id:3425,x:31153,y:34064,varname:node_3425,prsc:2|A-7550-OUT,B-7662-OUT;n:type:ShaderForge.SFN_Vector1,id:7662,x:31153,y:34209,varname:node_7662,prsc:2,v1:-0.3;n:type:ShaderForge.SFN_Multiply,id:5522,x:31354,y:34064,varname:node_5522,prsc:2|A-3425-OUT,B-5987-OUT;n:type:ShaderForge.SFN_Vector1,id:5987,x:31354,y:34209,varname:node_5987,prsc:2,v1:4;n:type:ShaderForge.SFN_Add,id:367,x:31694,y:33997,varname:node_367,prsc:2|A-9587-OUT,B-5522-OUT;n:type:ShaderForge.SFN_Multiply,id:4423,x:31886,y:33997,varname:node_4423,prsc:2|A-367-OUT,B-7619-OUT;n:type:ShaderForge.SFN_Vector1,id:7619,x:31886,y:34128,varname:node_7619,prsc:2,v1:-1;n:type:ShaderForge.SFN_Vector1,id:7618,x:31916,y:34294,varname:node_7618,prsc:2,v1:20;n:type:ShaderForge.SFN_Clamp,id:2708,x:32103,y:33997,varname:node_2708,prsc:2|IN-4423-OUT,MIN-6289-OUT,MAX-929-OUT;n:type:ShaderForge.SFN_Vector1,id:6289,x:32103,y:34140,varname:node_6289,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Vector1,id:929,x:32103,y:34191,varname:node_929,prsc:2,v1:1.1;n:type:ShaderForge.SFN_Fresnel,id:3622,x:32103,y:34294,varname:node_3622,prsc:2|EXP-7618-OUT;n:type:ShaderForge.SFN_Step,id:670,x:32391,y:34145,cmnt:backlighting always behind,varname:node_670,prsc:2|A-2708-OUT,B-3622-OUT;n:type:ShaderForge.SFN_Color,id:1210,x:32465,y:34382,ptovrint:False,ptlb:bright rim light amount,ptin:_brightrimlightamount,cmnt:grey color makes it blend into tex ,varname:_thickbacklightblendamount_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3018868,c2:0.3018868,c3:0.3018868,c4:1;n:type:ShaderForge.SFN_Multiply,id:7923,x:32820,y:34066,cmnt:DONE backlight,varname:node_7923,prsc:2|A-670-OUT,B-1210-RGB;proporder:5374-4081-2762-1002-271-1210;pass:END;sub:END;*/

Shader "Shader Forge/pnp_main shader" {
    Properties {
        _maintex ("main tex", 2D) = "white" {}
        _ramptex ("ramp tex", 2D) = "white" {}
        _faintglowaroundedgesblendamount ("faint glow around edges blend amount", Color) = (0.07843138,0.07843138,0.07843138,1)
        _thickbacklightblendamount ("thick backlight blend amount", Color) = (0.05882353,0.05882353,0.05882353,1)
        _subtleedgelightblendingamount ("subtle edge light blending amount", Color) = (0.3584906,0.3584906,0.3584906,1)
        _brightrimlightamount ("bright rim light amount", Color) = (0.3018868,0.3018868,0.3018868,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _maintex; uniform float4 _maintex_ST;
            uniform sampler2D _ramptex; uniform float4 _ramptex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _thickbacklightblendamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _subtleedgelightblendingamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _faintglowaroundedgesblendamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _brightrimlightamount)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
////// Emissive:
                float4 _subtleedgelightblendingamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _subtleedgelightblendingamount );
                float4 _maintex_var = tex2D(_maintex,TRANSFORM_TEX(i.uv0, _maintex));
                float2 node_2845 = float2((0.5+(0.49*dot(lightDirection,i.normalDir))),0.0); // reading ramp horiztonally
                float4 _ramptex_var = tex2D(_ramptex,TRANSFORM_TEX(node_2845, _ramptex));
                float4 _thickbacklightblendamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _thickbacklightblendamount ); // grey color makes it blend into tex 
                float4 _brightrimlightamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _brightrimlightamount ); // grey color makes it blend into tex 
                float4 _faintglowaroundedgesblendamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _faintglowaroundedgesblendamount );
                float3 emissive = ((((step(((1.0 - (saturate((dot(lightDirection,viewDirection)+(-0.6)))*2.0))+0.01),pow(1.0-max(0,dot(normalDirection, viewDirection)),10.0))*_subtleedgelightblendingamount_var.rgb)+((_maintex_var.rgb*_ramptex_var.rgb)+(step(clamp((((dot(lightDirection,(viewDirection*(-1.0)))+(-0.5))+((dot(lightDirection,i.normalDir)+(-0.3))*4.0))*(-1.0)),0.0001,1.1),pow(1.0-max(0,dot(normalDirection, viewDirection)),8.0))*_thickbacklightblendamount_var.rgb)))+(step(clamp((((dot(lightDirection,(viewDirection*(-1.0)))+(-0.5))+((dot(lightDirection,i.normalDir)+(-0.3))*4.0))*(-1.0)),0.1,1.1),pow(1.0-max(0,dot(normalDirection, viewDirection)),20.0))*_brightrimlightamount_var.rgb))+(pow(1.0-max(0,dot(normalDirection, viewDirection)),1.0)*_faintglowaroundedgesblendamount_var.rgb));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _maintex; uniform float4 _maintex_ST;
            uniform sampler2D _ramptex; uniform float4 _ramptex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _thickbacklightblendamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _subtleedgelightblendingamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _faintglowaroundedgesblendamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _brightrimlightamount)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
////// Lighting:
                float3 finalColor = 0;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _maintex; uniform float4 _maintex_ST;
            uniform sampler2D _ramptex; uniform float4 _ramptex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float4, _thickbacklightblendamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _subtleedgelightblendingamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _faintglowaroundedgesblendamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _brightrimlightamount)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 _subtleedgelightblendingamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _subtleedgelightblendingamount );
                float4 _maintex_var = tex2D(_maintex,TRANSFORM_TEX(i.uv0, _maintex));
                float2 node_2845 = float2((0.5+(0.49*dot(lightDirection,i.normalDir))),0.0); // reading ramp horiztonally
                float4 _ramptex_var = tex2D(_ramptex,TRANSFORM_TEX(node_2845, _ramptex));
                float4 _thickbacklightblendamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _thickbacklightblendamount ); // grey color makes it blend into tex 
                float4 _brightrimlightamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _brightrimlightamount ); // grey color makes it blend into tex 
                float4 _faintglowaroundedgesblendamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _faintglowaroundedgesblendamount );
                o.Emission = ((((step(((1.0 - (saturate((dot(lightDirection,viewDirection)+(-0.6)))*2.0))+0.01),pow(1.0-max(0,dot(normalDirection, viewDirection)),10.0))*_subtleedgelightblendingamount_var.rgb)+((_maintex_var.rgb*_ramptex_var.rgb)+(step(clamp((((dot(lightDirection,(viewDirection*(-1.0)))+(-0.5))+((dot(lightDirection,i.normalDir)+(-0.3))*4.0))*(-1.0)),0.0001,1.1),pow(1.0-max(0,dot(normalDirection, viewDirection)),8.0))*_thickbacklightblendamount_var.rgb)))+(step(clamp((((dot(lightDirection,(viewDirection*(-1.0)))+(-0.5))+((dot(lightDirection,i.normalDir)+(-0.3))*4.0))*(-1.0)),0.1,1.1),pow(1.0-max(0,dot(normalDirection, viewDirection)),20.0))*_brightrimlightamount_var.rgb))+(pow(1.0-max(0,dot(normalDirection, viewDirection)),1.0)*_faintglowaroundedgesblendamount_var.rgb));
                
                float3 diffColor = float3(0,0,0);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, 0, specColor, specularMonochrome );
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
