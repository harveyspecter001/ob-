using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C91 RID: 3217
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterUpdatedNameEvent : IMessage<CharacterUpdatedNameEvent>, IMessage, IEquatable<CharacterUpdatedNameEvent>, IDeepCloneable<CharacterUpdatedNameEvent>, IBufferMessage
	{
		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06009A98 RID: 39576 RVA: 0x0027D2B0 File Offset: 0x0027B4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterUpdatedNameEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06009A99 RID: 39577 RVA: 0x0027D2C0 File Offset: 0x0027B4C0
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

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06009A9A RID: 39578 RVA: 0x0027D2D0 File Offset: 0x0027B4D0
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

		// Token: 0x06009A9B RID: 39579 RVA: 0x0027D2E0 File Offset: 0x0027B4E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedNameEvent()
		{
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x0027D2F0 File Offset: 0x0027B4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedNameEvent(CharacterUpdatedNameEvent other)
		{
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x0027D300 File Offset: 0x0027B500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedNameEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06009A9E RID: 39582 RVA: 0x0027D310 File Offset: 0x0027B510
		// (set) Token: 0x06009A9F RID: 39583 RVA: 0x0027D320 File Offset: 0x0027B520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06009AA0 RID: 39584 RVA: 0x0027D330 File Offset: 0x0027B530
		// (set) Token: 0x06009AA1 RID: 39585 RVA: 0x0027D344 File Offset: 0x0027B544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NameCompliance Detail
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (NameCompliance)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x0027D354 File Offset: 0x0027B554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x0027D364 File Offset: 0x0027B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterUpdatedNameEvent other)
		{
			return true;
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x0027D374 File Offset: 0x0027B574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x0027D384 File Offset: 0x0027B584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009AA6 RID: 39590 RVA: 0x0027D394 File Offset: 0x0027B594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x0027D3A4 File Offset: 0x0027B5A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009AA8 RID: 39592 RVA: 0x0027D3B4 File Offset: 0x0027B5B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009AA9 RID: 39593 RVA: 0x0027D3C4 File Offset: 0x0027B5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterUpdatedNameEvent other)
		{
		}

		// Token: 0x06009AAA RID: 39594 RVA: 0x0027D3D4 File Offset: 0x0027B5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009AAB RID: 39595 RVA: 0x0027D3E4 File Offset: 0x0027B5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009AAC RID: 39596 RVA: 0x0027D3F4 File Offset: 0x0027B5F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterUpdatedNameEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					CharacterUpdatedNameEvent._parser = new MessageParser<CharacterUpdatedNameEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x0027D4D8 File Offset: 0x0027B6D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O2lvjcJxx2QF20BxRdnU()
		{
			return true;
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x0027D4E0 File Offset: 0x0027B6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterUpdatedNameEvent DvNAI6Jx4d02LN7tmHVH()
		{
			return null;
		}

		// Token: 0x04003955 RID: 14677
		private static readonly MessageParser<CharacterUpdatedNameEvent> _parser;

		// Token: 0x04003956 RID: 14678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003957 RID: 14679
		public const int NameFieldNumber = 1;

		// Token: 0x04003958 RID: 14680
		private string name_;

		// Token: 0x04003959 RID: 14681
		public const int DetailFieldNumber = 2;

		// Token: 0x0400395A RID: 14682
		private NameCompliance detail_;

		// Token: 0x0400395B RID: 14683
		internal static CharacterUpdatedNameEvent Ep1wpbJxNNYAKk0dXAi8;
	}
}
