using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BF6 RID: 3062
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakApiKeyEvent : IMessage<BakApiKeyEvent>, IMessage, IEquatable<BakApiKeyEvent>, IDeepCloneable<BakApiKeyEvent>, IBufferMessage
	{
		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x0600934A RID: 37706 RVA: 0x00272C94 File Offset: 0x00270E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakApiKeyEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x00272CA4 File Offset: 0x00270EA4
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

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x0600934C RID: 37708 RVA: 0x00272CB4 File Offset: 0x00270EB4
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

		// Token: 0x0600934D RID: 37709 RVA: 0x00272CC4 File Offset: 0x00270EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakApiKeyEvent()
		{
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x00272CD4 File Offset: 0x00270ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakApiKeyEvent(BakApiKeyEvent other)
		{
		}

		// Token: 0x0600934F RID: 37711 RVA: 0x00272CE4 File Offset: 0x00270EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakApiKeyEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06009350 RID: 37712 RVA: 0x00272CF4 File Offset: 0x00270EF4
		// (set) Token: 0x06009351 RID: 37713 RVA: 0x00272D04 File Offset: 0x00270F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x00272D14 File Offset: 0x00270F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x00272D24 File Offset: 0x00270F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakApiKeyEvent other)
		{
			return true;
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x00272D34 File Offset: 0x00270F34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009355 RID: 37717 RVA: 0x00272D44 File Offset: 0x00270F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x00272D54 File Offset: 0x00270F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x00272D64 File Offset: 0x00270F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x00272D74 File Offset: 0x00270F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x00272D84 File Offset: 0x00270F84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakApiKeyEvent other)
		{
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x00272D94 File Offset: 0x00270F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x00272DA4 File Offset: 0x00270FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x00272DB4 File Offset: 0x00270FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakApiKeyEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					BakApiKeyEvent._parser = new MessageParser<BakApiKeyEvent>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x00272E80 File Offset: 0x00271080
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nvPeQjJEt6MlwcZrY57c()
		{
			return true;
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x00272E88 File Offset: 0x00271088
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakApiKeyEvent YyVLLXJEwUZ1GkhNexbQ()
		{
			return null;
		}

		// Token: 0x040036DA RID: 14042
		private static readonly MessageParser<BakApiKeyEvent> _parser;

		// Token: 0x040036DB RID: 14043
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036DC RID: 14044
		public const int TokenFieldNumber = 1;

		// Token: 0x040036DD RID: 14045
		private string token_;

		// Token: 0x040036DE RID: 14046
		internal static BakApiKeyEvent Db1BJRJED3HdWI8JHjrh;
	}
}
