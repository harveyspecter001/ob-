using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002A0 RID: 672
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AutoFollowActivationRequest : IMessage<AutoFollowActivationRequest>, IMessage, IEquatable<AutoFollowActivationRequest>, IDeepCloneable<AutoFollowActivationRequest>, IBufferMessage
	{
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x001B8BD8 File Offset: 0x001B6DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AutoFollowActivationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x001B8BE8 File Offset: 0x001B6DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x001B8BF8 File Offset: 0x001B6DF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x001B8C08 File Offset: 0x001B6E08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivationRequest()
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x001B8C18 File Offset: 0x001B6E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivationRequest(AutoFollowActivationRequest other)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x001B8C28 File Offset: 0x001B6E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AutoFollowActivationRequest Clone()
		{
			return null;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x001B8C38 File Offset: 0x001B6E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x001B8C48 File Offset: 0x001B6E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AutoFollowActivationRequest other)
		{
			return true;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x001B8C58 File Offset: 0x001B6E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x001B8C68 File Offset: 0x001B6E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x001B8C78 File Offset: 0x001B6E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x001B8C88 File Offset: 0x001B6E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x001B8C98 File Offset: 0x001B6E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x001B8CA8 File Offset: 0x001B6EA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AutoFollowActivationRequest other)
		{
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x001B8CB8 File Offset: 0x001B6EB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x001B8CC8 File Offset: 0x001B6EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x001B8CD8 File Offset: 0x001B6ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AutoFollowActivationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					AutoFollowActivationRequest._parser = new MessageParser<AutoFollowActivationRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x001B8DA4 File Offset: 0x001B6FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wb9eiDOyisPrjSLIsV4f()
		{
			return true;
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x001B8DAC File Offset: 0x001B6FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoFollowActivationRequest QeHXtAOyPSjy6gvwaP99()
		{
			return null;
		}

		// Token: 0x04000B17 RID: 2839
		private static readonly MessageParser<AutoFollowActivationRequest> _parser;

		// Token: 0x04000B18 RID: 2840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B19 RID: 2841
		private static AutoFollowActivationRequest t3wvu5OybwCXE570Suca;
	}
}
