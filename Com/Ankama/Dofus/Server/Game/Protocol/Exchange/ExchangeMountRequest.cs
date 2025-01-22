using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006EA RID: 1770
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountRequest : IMessage<ExchangeMountRequest>, IMessage, IEquatable<ExchangeMountRequest>, IDeepCloneable<ExchangeMountRequest>, IBufferMessage
	{
		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x0600569A RID: 22170 RVA: 0x00213EF4 File Offset: 0x002120F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeMountRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x0600569B RID: 22171 RVA: 0x00213F04 File Offset: 0x00212104
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

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x0600569C RID: 22172 RVA: 0x00213F14 File Offset: 0x00212114
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

		// Token: 0x0600569D RID: 22173 RVA: 0x00213F24 File Offset: 0x00212124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountRequest()
		{
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00213F34 File Offset: 0x00212134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountRequest(ExchangeMountRequest other)
		{
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x00213F44 File Offset: 0x00212144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountRequest Clone()
		{
			return null;
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x00213F54 File Offset: 0x00212154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00213F64 File Offset: 0x00212164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountRequest other)
		{
			return true;
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x00213F74 File Offset: 0x00212174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00213F84 File Offset: 0x00212184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00213F94 File Offset: 0x00212194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x00213FA4 File Offset: 0x002121A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x00213FB4 File Offset: 0x002121B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x00213FC4 File Offset: 0x002121C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountRequest other)
		{
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x00213FD4 File Offset: 0x002121D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00213FE4 File Offset: 0x002121E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00213FF4 File Offset: 0x002121F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						continue;
					case 2:
						ExchangeMountRequest._parser = new MessageParser<ExchangeMountRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_AC;
					}
					return;
				}
				IL_AC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x002140C4 File Offset: 0x002122C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AbtylCOMCPTq39n1ywK3()
		{
			return true;
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x002140CC File Offset: 0x002122CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountRequest mG2fa6OMDBWjMvg21B4Z()
		{
			return null;
		}

		// Token: 0x04001E5C RID: 7772
		private static readonly MessageParser<ExchangeMountRequest> _parser;

		// Token: 0x04001E5D RID: 7773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E5E RID: 7774
		internal static ExchangeMountRequest BF6AXNOM0CYoRiuaEQG1;
	}
}
