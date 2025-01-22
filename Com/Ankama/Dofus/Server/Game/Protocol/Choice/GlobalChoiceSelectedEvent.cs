using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008CB RID: 2251
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GlobalChoiceSelectedEvent : IMessage<GlobalChoiceSelectedEvent>, IMessage, IEquatable<GlobalChoiceSelectedEvent>, IDeepCloneable<GlobalChoiceSelectedEvent>, IBufferMessage
	{
		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06006D67 RID: 28007 RVA: 0x00234550 File Offset: 0x00232750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GlobalChoiceSelectedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06006D68 RID: 28008 RVA: 0x00234560 File Offset: 0x00232760
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

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x00234570 File Offset: 0x00232770
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

		// Token: 0x06006D6A RID: 28010 RVA: 0x00234580 File Offset: 0x00232780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectedEvent()
		{
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x00234590 File Offset: 0x00232790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectedEvent(GlobalChoiceSelectedEvent other)
		{
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x002345A0 File Offset: 0x002327A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectedEvent Clone()
		{
			return null;
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06006D6D RID: 28013 RVA: 0x002345B0 File Offset: 0x002327B0
		// (set) Token: 0x06006D6E RID: 28014 RVA: 0x002345C0 File Offset: 0x002327C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x002345D0 File Offset: 0x002327D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x002345E0 File Offset: 0x002327E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GlobalChoiceSelectedEvent other)
		{
			return true;
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x002345F0 File Offset: 0x002327F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x00234600 File Offset: 0x00232800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x00234610 File Offset: 0x00232810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x00234620 File Offset: 0x00232820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x00234630 File Offset: 0x00232830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x00234640 File Offset: 0x00232840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GlobalChoiceSelectedEvent other)
		{
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x00234650 File Offset: 0x00232850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x00234660 File Offset: 0x00232860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x00234670 File Offset: 0x00232870
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GlobalChoiceSelectedEvent()
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
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					GlobalChoiceSelectedEvent._parser = new MessageParser<GlobalChoiceSelectedEvent>(() => null);
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x0023473C File Offset: 0x0023293C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ytjf4PJAyNE6yDUbaoAo()
		{
			return true;
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x00234744 File Offset: 0x00232944
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GlobalChoiceSelectedEvent yYWW4HJA6sJN2EgL11rH()
		{
			return null;
		}

		// Token: 0x04002626 RID: 9766
		private static readonly MessageParser<GlobalChoiceSelectedEvent> _parser;

		// Token: 0x04002627 RID: 9767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002628 RID: 9768
		public const int PositionFieldNumber = 1;

		// Token: 0x04002629 RID: 9769
		private int position_;

		// Token: 0x0400262A RID: 9770
		internal static GlobalChoiceSelectedEvent vRufFiJA5My2w4P9mp13;
	}
}
