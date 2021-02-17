// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33194,y:32569,varname:node_3138,prsc:2|emission-67-OUT;n:type:ShaderForge.SFN_Tex2d,id:7153,x:32892,y:32413,ptovrint:False,ptlb:base material,ptin:_basematerial,varname:node_7153,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:08a6669ca3c82b44280abcdf3bfaebb5,ntxv:3,isnm:False;n:type:ShaderForge.SFN_LightVector,id:4154,x:31906,y:32412,varname:node_4154,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:1351,x:31906,y:32538,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:9639,x:32123,y:32412,varname:node_9639,prsc:2,dt:0|A-4154-OUT,B-1351-OUT;n:type:ShaderForge.SFN_Step,id:9449,x:32374,y:32372,varname:node_9449,prsc:2|A-7439-OUT,B-9639-OUT;n:type:ShaderForge.SFN_Vector1,id:7439,x:32087,y:32610,varname:node_7439,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:3840,x:32381,y:32685,ptovrint:False,ptlb:soft ramp,ptin:_softramp,varname:node_3840,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ae1ea83ef1f15e54ba92294e1ea482aa,ntxv:3,isnm:False|UVIN-9586-OUT;n:type:ShaderForge.SFN_Append,id:9586,x:32180,y:32718,varname:node_9586,prsc:2|A-9639-OUT,B-6465-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6465,x:31944,y:32826,ptovrint:False,ptlb:static y-value,ptin:_staticyvalue,varname:node_6465,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:1587,x:32632,y:32542,varname:node_1587,prsc:2;n:type:ShaderForge.SFN_Blend,id:67,x:32890,y:32828,varname:node_67,prsc:2,blmd:10,clmp:True|SRC-7153-RGB,DST-3840-RGB;proporder:7153-3840-6465;pass:END;sub:END;*/

Shader "Shader Forge/messing around" {
    Properties {
        _basematerial ("base material", 2D) = "bump" {}
        _softramp ("soft ramp", 2D) = "bump" {}
        _staticyvalue ("static y-value", Float ) = 0
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
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma target 3.0
            uniform sampler2D _basematerial; uniform float4 _basematerial_ST;
            uniform sampler2D _softramp; uniform float4 _softramp_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _staticyvalue)
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
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
////// Emissive:
                float4 _basematerial_var = tex2D(_basematerial,TRANSFORM_TEX(i.uv0, _basematerial));
                float node_9639 = dot(lightDirection,i.normalDir);
                float _staticyvalue_var = UNITY_ACCESS_INSTANCED_PROP( Props, _staticyvalue );
                float2 node_9586 = float2(node_9639,_staticyvalue_var);
                float4 _softramp_var = tex2D(_softramp,TRANSFORM_TEX(node_9586, _softramp));
                float3 emissive = saturate(( _softramp_var.rgb > 0.5 ? (1.0-(1.0-2.0*(_softramp_var.rgb-0.5))*(1.0-_basematerial_var.rgb)) : (2.0*_softramp_var.rgb*_basematerial_var.rgb) ));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
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
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma target 3.0
            uniform sampler2D _basematerial; uniform float4 _basematerial_ST;
            uniform sampler2D _softramp; uniform float4 _softramp_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _staticyvalue)
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
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
////// Lighting:
                float3 finalColor = 0;
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
