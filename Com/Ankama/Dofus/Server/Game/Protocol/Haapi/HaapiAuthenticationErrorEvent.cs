using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi
{
	// Token: 0x020004B2 RID: 1202
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HaapiAuthenticationErrorEvent : IMessage<HaapiAuthenticationErrorEvent>, IMessage, IEquatable<HaapiAuthenticationErrorEvent>, IDeepCloneable<HaapiAuthenticationErrorEvent>, IBufferMessage
	{
		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x001E1DFC File Offset: 0x001DFFFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HaapiAuthenticationErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x001E1E0C File Offset: 0x001E000C
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

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x001E1E1C File Offset: 0x001E001C
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

		// Token: 0x06003978 RID: 14712 RVA: 0x001E1E2C File Offset: 0x001E002C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiAuthenticationErrorEvent()
		{
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x001E1E3C File Offset: 0x001E003C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiAuthenticationErrorEvent(HaapiAuthenticationErrorEvent other)
		{
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x001E1E4C File Offset: 0x001E004C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiAuthenticationErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x001E1E5C File Offset: 0x001E005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x001E1E6C File Offset: 0x001E006C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HaapiAuthenticationErrorEvent other)
		{
			return true;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x001E1E7C File Offset: 0x001E007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x001E1E8C File Offset: 0x001E008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x001E1E9C File Offset: 0x001E009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x001E1EAC File Offset: 0x001E00AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x001E1EBC File Offset: 0x001E00BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x001E1ECC File Offset: 0x001E00CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HaapiAuthenticationErrorEvent other)
		{
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x001E1EDC File Offset: 0x001E00DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x001E1EEC File Offset: 0x001E00EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x001E1EFC File Offset: 0x001E00FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HaapiAuthenticationErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				HaapiAuthenticationErrorEvent._parser = new MessageParser<HaapiAuthenticationErrorEvent>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x001E1FE0 File Offset: 0x001E01E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jCaRPSOQGYhGDHr085Tc()
		{
			return true;
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x001E1FE8 File Offset: 0x001E01E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HaapiAuthenticationErrorEvent iZqSs0OQgjjAIU7G6m8Z()
		{
			return null;
		}

		// Token: 0x04001405 RID: 5125
		private static readonly MessageParser<HaapiAuthenticationErrorEvent> _parser;

		// Token: 0x04001406 RID: 5126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001407 RID: 5127
		internal static HaapiAuthenticationErrorEvent sZo7bYOQJhEUJSZMSXsO;
	}
}
