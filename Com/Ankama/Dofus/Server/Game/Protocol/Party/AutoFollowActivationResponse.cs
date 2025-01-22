using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002A2 RID: 674
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AutoFollowActivationResponse : IMessage<AutoFollowActivationResponse>, IMessage, IEquatable<AutoFollowActivationResponse>, IDeepCloneable<AutoFollowActivationResponse>, IBufferMessage
	{
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x001B8DB4 File Offset: 0x001B6FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AutoFollowActivationResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x001B8DC4 File Offset: 0x001B6FC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x001B8DD4 File Offset: 0x001B6FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x001B8DE4 File Offset: 0x001B6FE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivationResponse()
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x001B8DF4 File Offset: 0x001B6FF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivationResponse(AutoFollowActivationResponse other)
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x001B8E04 File Offset: 0x001B7004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivationResponse Clone()
		{
			return null;
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x001B8E14 File Offset: 0x001B7014
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x001B8E28 File Offset: 0x001B7028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AutoFollowActivationResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AutoFollowActivationResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x001B8E38 File Offset: 0x001B7038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x001B8E48 File Offset: 0x001B7048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AutoFollowActivationResponse other)
		{
			return true;
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x001B8E58 File Offset: 0x001B7058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x001B8E68 File Offset: 0x001B7068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x001B8E78 File Offset: 0x001B7078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x001B8E88 File Offset: 0x001B7088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x001B8E98 File Offset: 0x001B7098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x001B8EA8 File Offset: 0x001B70A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AutoFollowActivationResponse other)
		{
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x001B8EB8 File Offset: 0x001B70B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x001B8EC8 File Offset: 0x001B70C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x001B8ED8 File Offset: 0x001B70D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AutoFollowActivationResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_5E;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 4:
						AutoFollowActivationResponse._parser = new MessageParser<AutoFollowActivationResponse>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_5E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x001B8FA8 File Offset: 0x001B71A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CFl8qAOyM7LLTpuUcY9O()
		{
			return true;
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x001B8FB0 File Offset: 0x001B71B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoFollowActivationResponse Pq3oAQOyu3581uUARvvD()
		{
			return null;
		}

		// Token: 0x04000B1C RID: 2844
		private static readonly MessageParser<AutoFollowActivationResponse> _parser;

		// Token: 0x04000B1D RID: 2845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B1E RID: 2846
		public const int ResultFieldNumber = 1;

		// Token: 0x04000B1F RID: 2847
		private AutoFollowActivationResponse.Types.Result result_;

		// Token: 0x04000B20 RID: 2848
		private static AutoFollowActivationResponse kXiA6rOyS1JBetDGv0UG;

		// Token: 0x020002A3 RID: 675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001F9D RID: 8093 RVA: 0x002B404C File Offset: 0x002B224C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020002A4 RID: 676
			public enum Result
			{
				// Token: 0x04000B22 RID: 2850
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04000B23 RID: 2851
				[OriginalName("ERROR")]
				Error
			}
		}
	}
}
