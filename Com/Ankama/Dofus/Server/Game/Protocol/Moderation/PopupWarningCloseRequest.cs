using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Moderation
{
	// Token: 0x02000395 RID: 917
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PopupWarningCloseRequest : IMessage<PopupWarningCloseRequest>, IMessage, IEquatable<PopupWarningCloseRequest>, IDeepCloneable<PopupWarningCloseRequest>, IBufferMessage
	{
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x001C9A0C File Offset: 0x001C7C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PopupWarningCloseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x001C9A1C File Offset: 0x001C7C1C
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

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x001C9A2C File Offset: 0x001C7C2C
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

		// Token: 0x06002AF2 RID: 10994 RVA: 0x001C9A3C File Offset: 0x001C7C3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningCloseRequest()
		{
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x001C9A4C File Offset: 0x001C7C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningCloseRequest(PopupWarningCloseRequest other)
		{
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x001C9A5C File Offset: 0x001C7C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupWarningCloseRequest Clone()
		{
			return null;
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x001C9A6C File Offset: 0x001C7C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x001C9A7C File Offset: 0x001C7C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PopupWarningCloseRequest other)
		{
			return true;
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x001C9A8C File Offset: 0x001C7C8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x001C9A9C File Offset: 0x001C7C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x001C9AAC File Offset: 0x001C7CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x001C9ABC File Offset: 0x001C7CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x001C9ACC File Offset: 0x001C7CCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x001C9ADC File Offset: 0x001C7CDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PopupWarningCloseRequest other)
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x001C9AEC File Offset: 0x001C7CEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x001C9AFC File Offset: 0x001C7CFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x001C9B0C File Offset: 0x001C7D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PopupWarningCloseRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					PopupWarningCloseRequest._parser = new MessageParser<PopupWarningCloseRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x001C9BF0 File Offset: 0x001C7DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jvJ3s7OrbufCMaCnboEe()
		{
			return true;
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x001C9BF8 File Offset: 0x001C7DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PopupWarningCloseRequest bl3H3tOrigI6aiLTFfXp()
		{
			return null;
		}

		// Token: 0x04000F26 RID: 3878
		private static readonly MessageParser<PopupWarningCloseRequest> _parser;

		// Token: 0x04000F27 RID: 3879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F28 RID: 3880
		private static PopupWarningCloseRequest bjTUMWOrYnaQ0T7wZp0O;
	}
}
