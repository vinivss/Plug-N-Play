// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33609,y:32900,varname:node_2865,prsc:2|emission-3826-OUT;n:type:ShaderForge.SFN_Tex2d,id:9145,x:32160,y:32774,ptovrint:False,ptlb:main texture,ptin:_maintexture,varname:node_9145,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_LightVector,id:8093,x:31538,y:32534,varname:node_8093,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:4655,x:31538,y:32665,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:167,x:31741,y:32534,varname:node_167,prsc:2,dt:0|A-8093-OUT,B-4655-OUT;n:type:ShaderForge.SFN_Multiply,id:2351,x:31741,y:32774,cmnt:scaling and scooting the og values to zero to one,varname:node_2351,prsc:2|A-4011-OUT,B-167-OUT;n:type:ShaderForge.SFN_Vector1,id:4011,x:31741,y:32709,varname:node_4011,prsc:2,v1:0.49;n:type:ShaderForge.SFN_Add,id:3738,x:31920,y:32774,varname:node_3738,prsc:2|A-8350-OUT,B-2351-OUT;n:type:ShaderForge.SFN_Vector1,id:8350,x:31920,y:32709,varname:node_8350,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:527,x:31824,y:32928,ptovrint:False,ptlb:ramp,ptin:_ramp,varname:node_527,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:4e9b00f1a62051f46b72a088f1cf80b7,ntxv:0,isnm:False|UVIN-252-OUT;n:type:ShaderForge.SFN_Append,id:252,x:31592,y:32928,cmnt:reading ramp horiztonally,varname:node_252,prsc:2|A-3738-OUT,B-7848-OUT;n:type:ShaderForge.SFN_Vector1,id:7848,x:31592,y:33060,varname:node_7848,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:7703,x:32373,y:32937,cmnt:DONE ramp based cel shader,varname:node_7703,prsc:2|A-9145-RGB,B-527-RGB;n:type:ShaderForge.SFN_AmbientLight,id:4252,x:31824,y:33110,varname:node_4252,prsc:2;n:type:ShaderForge.SFN_Add,id:7999,x:32015,y:33110,cmnt:adding ambient light from surroundings,varname:node_7999,prsc:2|B-4252-A;n:type:ShaderForge.SFN_ViewVector,id:4289,x:31619,y:32065,varname:node_4289,prsc:2;n:type:ShaderForge.SFN_Add,id:1642,x:31965,y:32065,varname:node_1642,prsc:2|A-5065-OUT,B-8093-OUT;n:type:ShaderForge.SFN_NormalVector,id:8337,x:31732,y:32219,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:4802,x:32341,y:32209,varname:node_4802,prsc:2|A-1048-OUT,B-527-RGB;n:type:ShaderForge.SFN_Dot,id:1048,x:32154,y:32209,varname:node_1048,prsc:2,dt:0|A-7066-OUT,B-315-OUT;n:type:ShaderForge.SFN_Power,id:7041,x:32529,y:32209,varname:node_7041,prsc:2|VAL-4802-OUT,EXP-4548-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4548,x:32529,y:32358,ptovrint:False,ptlb:shininess,ptin:_shininess,varname:node_4548,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Smoothstep,id:5343,x:32435,y:32458,cmnt:specular highlight,varname:node_5343,prsc:2|A-3906-OUT,B-5310-OUT,V-7041-OUT;n:type:ShaderForge.SFN_Add,id:8983,x:32738,y:32678,cmnt:cal base plus highlight,varname:node_8983,prsc:2|A-5343-OUT,B-7703-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3906,x:32215,y:32458,ptovrint:False,ptlb:specular smooth min,ptin:_specularsmoothmin,varname:node_3906,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01;n:type:ShaderForge.SFN_ValueProperty,id:5310,x:32215,y:32533,ptovrint:False,ptlb:specular smooth max,ptin:_specularsmoothmax,varname:_specularsmooth2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.02;n:type:ShaderForge.SFN_Normalize,id:5065,x:31794,y:32065,varname:node_5065,prsc:2|IN-4289-OUT;n:type:ShaderForge.SFN_Normalize,id:315,x:31904,y:32219,varname:node_315,prsc:2|IN-8337-OUT;n:type:ShaderForge.SFN_Normalize,id:7066,x:32138,y:32065,varname:node_7066,prsc:2|IN-1642-OUT;n:type:ShaderForge.SFN_Fresnel,id:124,x:32373,y:33297,varname:node_124,prsc:2|EXP-3931-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3931,x:32167,y:33381,ptovrint:False,ptlb:rim light strength,ptin:_rimlightstrength,varname:node_3931,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:8;n:type:ShaderForge.SFN_Smoothstep,id:8715,x:32593,y:33130,cmnt:rim light,varname:node_8715,prsc:2|A-2601-OUT,B-8219-OUT,V-124-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2601,x:32373,y:33130,ptovrint:False,ptlb:rim smooth min,ptin:_rimsmoothmin,varname:_specularsmoothmin_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.01;n:type:ShaderForge.SFN_ValueProperty,id:8219,x:32373,y:33205,ptovrint:False,ptlb:rim smooth max,ptin:_rimsmoothmax,varname:_specularsmoothmax_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.02;n:type:ShaderForge.SFN_Add,id:3826,x:33215,y:32895,varname:node_3826,prsc:2|A-8983-OUT,B-8715-OUT;proporder:9145-527-4548-3906-5310-3931-2601-8219;pass:END;sub:END;*/

Shader "Shader Forge/following demo" {
    Properties {
        _maintexture ("main texture", 2D) = "white" {}
        _ramp ("ramp", 2D) = "white" {}
        _shininess ("shininess", Float ) = 1
        _specularsmoothmin ("specular smooth min", Float ) = 0.01
        _specularsmoothmax ("specular smooth max", Float ) = 0.02
        _rimlightstrength ("rim light strength", Float ) = 8
        _rimsmoothmin ("rim smooth min", Float ) = 0.01
        _rimsmoothmax ("rim smooth max", Float ) = 0.02
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
            uniform sampler2D _maintexture; uniform float4 _maintexture_ST;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _shininess)
                UNITY_DEFINE_INSTANCED_PROP( float, _specularsmoothmin)
                UNITY_DEFINE_INSTANCED_PROP( float, _specularsmoothmax)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimlightstrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimsmoothmin)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimsmoothmax)
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
                float _specularsmoothmin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _specularsmoothmin );
                float _specularsmoothmax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _specularsmoothmax );
                float2 node_252 = float2((0.5+(0.49*dot(lightDirection,i.normalDir))),0.0); // reading ramp horiztonally
                float4 _ramp_var = tex2D(_ramp,TRANSFORM_TEX(node_252, _ramp));
                float _shininess_var = UNITY_ACCESS_INSTANCED_PROP( Props, _shininess );
                float4 _maintexture_var = tex2D(_maintexture,TRANSFORM_TEX(i.uv0, _maintexture));
                float3 node_8983 = (smoothstep( float3(_specularsmoothmin_var,_specularsmoothmin_var,_specularsmoothmin_var), float3(_specularsmoothmax_var,_specularsmoothmax_var,_specularsmoothmax_var), pow((dot(normalize((normalize(viewDirection)+lightDirection)),normalize(i.normalDir))*_ramp_var.rgb),_shininess_var) )+(_maintexture_var.rgb*_ramp_var.rgb)); // cal base plus highlight
                float _rimsmoothmin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _rimsmoothmin );
                float _rimsmoothmax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _rimsmoothmax );
                float _rimlightstrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _rimlightstrength );
                float node_8715 = smoothstep( _rimsmoothmin_var, _rimsmoothmax_var, pow(1.0-max(0,dot(normalDirection, viewDirection)),_rimlightstrength_var) ); // rim light
                float3 emissive = (node_8983+node_8715);
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
            uniform sampler2D _maintexture; uniform float4 _maintexture_ST;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _shininess)
                UNITY_DEFINE_INSTANCED_PROP( float, _specularsmoothmin)
                UNITY_DEFINE_INSTANCED_PROP( float, _specularsmoothmax)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimlightstrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimsmoothmin)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimsmoothmax)
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
            uniform sampler2D _maintexture; uniform float4 _maintexture_ST;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _shininess)
                UNITY_DEFINE_INSTANCED_PROP( float, _specularsmoothmin)
                UNITY_DEFINE_INSTANCED_PROP( float, _specularsmoothmax)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimlightstrength)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimsmoothmin)
                UNITY_DEFINE_INSTANCED_PROP( float, _rimsmoothmax)
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
                
                float _specularsmoothmin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _specularsmoothmin );
                float _specularsmoothmax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _specularsmoothmax );
                float2 node_252 = float2((0.5+(0.49*dot(lightDirection,i.normalDir))),0.0); // reading ramp horiztonally
                float4 _ramp_var = tex2D(_ramp,TRANSFORM_TEX(node_252, _ramp));
                float _shininess_var = UNITY_ACCESS_INSTANCED_PROP( Props, _shininess );
                float4 _maintexture_var = tex2D(_maintexture,TRANSFORM_TEX(i.uv0, _maintexture));
                float3 node_8983 = (smoothstep( float3(_specularsmoothmin_var,_specularsmoothmin_var,_specularsmoothmin_var), float3(_specularsmoothmax_var,_specularsmoothmax_var,_specularsmoothmax_var), pow((dot(normalize((normalize(viewDirection)+lightDirection)),normalize(i.normalDir))*_ramp_var.rgb),_shininess_var) )+(_maintexture_var.rgb*_ramp_var.rgb)); // cal base plus highlight
                float _rimsmoothmin_var = UNITY_ACCESS_INSTANCED_PROP( Props, _rimsmoothmin );
                float _rimsmoothmax_var = UNITY_ACCESS_INSTANCED_PROP( Props, _rimsmoothmax );
                float _rimlightstrength_var = UNITY_ACCESS_INSTANCED_PROP( Props, _rimlightstrength );
                float node_8715 = smoothstep( _rimsmoothmin_var, _rimsmoothmax_var, pow(1.0-max(0,dot(normalDirection, viewDirection)),_rimlightstrength_var) ); // rim light
                o.Emission = (node_8983+node_8715);
                
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
