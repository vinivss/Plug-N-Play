// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33128,y:33081,varname:node_2865,prsc:2|emission-5081-OUT;n:type:ShaderForge.SFN_Fresnel,id:225,x:31888,y:32796,varname:node_225,prsc:2|EXP-9946-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9946,x:31888,y:32708,ptovrint:False,ptlb:fresnel amount,ptin:_fresnelamount,varname:node_9946,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_LightVector,id:4994,x:31553,y:32393,varname:node_4994,prsc:2;n:type:ShaderForge.SFN_ViewVector,id:9885,x:31553,y:32524,varname:node_9885,prsc:2;n:type:ShaderForge.SFN_Dot,id:9638,x:31738,y:32393,varname:node_9638,prsc:2,dt:0|A-4994-OUT,B-9885-OUT;n:type:ShaderForge.SFN_Add,id:5933,x:31940,y:32393,varname:node_5933,prsc:2|A-9638-OUT,B-4737-OUT;n:type:ShaderForge.SFN_Vector1,id:4737,x:31940,y:32333,varname:node_4737,prsc:2,v1:-0.6;n:type:ShaderForge.SFN_Clamp01,id:4259,x:32128,y:32393,varname:node_4259,prsc:2|IN-5933-OUT;n:type:ShaderForge.SFN_Multiply,id:7923,x:32365,y:32453,varname:node_7923,prsc:2|A-4259-OUT,B-5188-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5188,x:32156,y:32555,ptovrint:False,ptlb:backlight amount,ptin:_backlightamount,varname:node_5188,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_OneMinus,id:3938,x:32544,y:32453,varname:node_3938,prsc:2|IN-7923-OUT;n:type:ShaderForge.SFN_Add,id:6539,x:32411,y:32623,varname:node_6539,prsc:2|A-3938-OUT,B-6622-OUT;n:type:ShaderForge.SFN_Vector1,id:6622,x:32411,y:32754,varname:node_6622,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Step,id:4312,x:32226,y:32921,cmnt:opposite of light rim lighting,varname:node_4312,prsc:2|A-6539-OUT,B-225-OUT;n:type:ShaderForge.SFN_NormalVector,id:1595,x:30464,y:33303,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:3278,x:30720,y:33252,varname:node_3278,prsc:2,dt:0|A-7503-OUT,B-1595-OUT;n:type:ShaderForge.SFN_ViewVector,id:1146,x:30818,y:32937,varname:node_1146,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9967,x:31049,y:32937,varname:node_9967,prsc:2|A-1146-OUT,B-2457-OUT;n:type:ShaderForge.SFN_Vector1,id:2457,x:30818,y:33098,varname:node_2457,prsc:2,v1:-1;n:type:ShaderForge.SFN_Dot,id:6585,x:31263,y:32829,varname:node_6585,prsc:2,dt:0|A-7503-OUT,B-9967-OUT;n:type:ShaderForge.SFN_LightVector,id:7503,x:30338,y:33090,varname:node_7503,prsc:2;n:type:ShaderForge.SFN_Add,id:46,x:31452,y:32829,varname:node_46,prsc:2|A-6585-OUT,B-9190-OUT;n:type:ShaderForge.SFN_Vector1,id:9190,x:31452,y:32968,varname:node_9190,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Add,id:8090,x:30911,y:33252,varname:node_8090,prsc:2|A-3278-OUT,B-7609-OUT;n:type:ShaderForge.SFN_Vector1,id:7609,x:30911,y:33397,varname:node_7609,prsc:2,v1:-0.3;n:type:ShaderForge.SFN_Multiply,id:2584,x:31112,y:33252,varname:node_2584,prsc:2|A-8090-OUT,B-5893-OUT;n:type:ShaderForge.SFN_Vector1,id:5893,x:31112,y:33397,varname:node_5893,prsc:2,v1:4;n:type:ShaderForge.SFN_Add,id:4750,x:31452,y:33185,varname:node_4750,prsc:2|A-46-OUT,B-2584-OUT;n:type:ShaderForge.SFN_Multiply,id:4176,x:31644,y:33185,varname:node_4176,prsc:2|A-4750-OUT,B-2030-OUT;n:type:ShaderForge.SFN_Vector1,id:2030,x:31644,y:33316,varname:node_2030,prsc:2,v1:-1;n:type:ShaderForge.SFN_Clamp,id:4293,x:31861,y:33185,varname:node_4293,prsc:2|IN-4176-OUT,MIN-6843-OUT,MAX-3076-OUT;n:type:ShaderForge.SFN_Vector1,id:6843,x:31861,y:33328,varname:node_6843,prsc:2,v1:0.02;n:type:ShaderForge.SFN_Vector1,id:3076,x:31861,y:33379,varname:node_3076,prsc:2,v1:1.1;n:type:ShaderForge.SFN_Fresnel,id:8409,x:31861,y:33482,varname:node_8409,prsc:2|EXP-3476-OUT;n:type:ShaderForge.SFN_Vector1,id:3476,x:31674,y:33482,varname:node_3476,prsc:2,v1:8;n:type:ShaderForge.SFN_Step,id:6933,x:32149,y:33333,cmnt:backlighting always behind,varname:node_6933,prsc:2|A-4293-OUT,B-8409-OUT;n:type:ShaderForge.SFN_Add,id:9417,x:32660,y:33169,varname:node_9417,prsc:2|A-4312-OUT,B-4287-OUT;n:type:ShaderForge.SFN_Tex2d,id:5905,x:32636,y:32934,ptovrint:False,ptlb:main tex,ptin:_maintex,varname:node_5905,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5324,x:33377,y:32887,varname:node_5324,prsc:2;n:type:ShaderForge.SFN_Add,id:5081,x:32926,y:33025,varname:node_5081,prsc:2|A-5905-RGB,B-9417-OUT;n:type:ShaderForge.SFN_Color,id:2246,x:32219,y:33518,ptovrint:False,ptlb:node_2246,ptin:_node_2246,varname:node_2246,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1037736,c2:0.1037736,c3:0.1037736,c4:1;n:type:ShaderForge.SFN_Multiply,id:4287,x:32443,y:33283,varname:node_4287,prsc:2|A-6933-OUT,B-2246-RGB;proporder:9946-5188-5905-2246;pass:END;sub:END;*/

Shader "Shader Forge/following another demo" {
    Properties {
        _fresnelamount ("fresnel amount", Float ) = 5
        _backlightamount ("backlight amount", Float ) = 2
        _maintex ("main tex", 2D) = "white" {}
        _node_2246 ("node_2246", Color) = (0.1037736,0.1037736,0.1037736,1)
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
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _fresnelamount)
                UNITY_DEFINE_INSTANCED_PROP( float, _backlightamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _node_2246)
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
                float4 _maintex_var = tex2D(_maintex,TRANSFORM_TEX(i.uv0, _maintex));
                float _backlightamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _backlightamount );
                float _fresnelamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _fresnelamount );
                float4 _node_2246_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_2246 );
                float3 emissive = (_maintex_var.rgb+(step(((1.0 - (saturate((dot(lightDirection,viewDirection)+(-0.6)))*_backlightamount_var))+0.01),pow(1.0-max(0,dot(normalDirection, viewDirection)),_fresnelamount_var))+(step(clamp((((dot(lightDirection,(viewDirection*(-1.0)))+(-0.5))+((dot(lightDirection,i.normalDir)+(-0.3))*4.0))*(-1.0)),0.02,1.1),pow(1.0-max(0,dot(normalDirection, viewDirection)),8.0))*_node_2246_var.rgb)));
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
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _fresnelamount)
                UNITY_DEFINE_INSTANCED_PROP( float, _backlightamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _node_2246)
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
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _fresnelamount)
                UNITY_DEFINE_INSTANCED_PROP( float, _backlightamount)
                UNITY_DEFINE_INSTANCED_PROP( float4, _node_2246)
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
                
                float4 _maintex_var = tex2D(_maintex,TRANSFORM_TEX(i.uv0, _maintex));
                float _backlightamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _backlightamount );
                float _fresnelamount_var = UNITY_ACCESS_INSTANCED_PROP( Props, _fresnelamount );
                float4 _node_2246_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_2246 );
                o.Emission = (_maintex_var.rgb+(step(((1.0 - (saturate((dot(lightDirection,viewDirection)+(-0.6)))*_backlightamount_var))+0.01),pow(1.0-max(0,dot(normalDirection, viewDirection)),_fresnelamount_var))+(step(clamp((((dot(lightDirection,(viewDirection*(-1.0)))+(-0.5))+((dot(lightDirection,i.normalDir)+(-0.3))*4.0))*(-1.0)),0.02,1.1),pow(1.0-max(0,dot(normalDirection, viewDirection)),8.0))*_node_2246_var.rgb)));
                
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
