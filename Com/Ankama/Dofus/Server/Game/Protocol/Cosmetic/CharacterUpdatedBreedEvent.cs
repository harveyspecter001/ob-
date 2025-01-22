using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C8D RID: 3213
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterUpdatedBreedEvent : IMessage<CharacterUpdatedBreedEvent>, IMessage, IEquatable<CharacterUpdatedBreedEvent>, IDeepCloneable<CharacterUpdatedBreedEvent>, IBufferMessage
	{
		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06009A5E RID: 39518 RVA: 0x0027CE54 File Offset: 0x0027B054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterUpdatedBreedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06009A5F RID: 39519 RVA: 0x0027CE64 File Offset: 0x0027B064
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

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06009A60 RID: 39520 RVA: 0x0027CE74 File Offset: 0x0027B074
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

		// Token: 0x06009A61 RID: 39521 RVA: 0x0027CE84 File Offset: 0x0027B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedBreedEvent()
		{
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x0027CE94 File Offset: 0x0027B094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedBreedEvent(CharacterUpdatedBreedEvent other)
		{
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x0027CEA4 File Offset: 0x0027B0A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedBreedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06009A64 RID: 39524 RVA: 0x0027CEB4 File Offset: 0x0027B0B4
		// (set) Token: 0x06009A65 RID: 39525 RVA: 0x0027CEC4 File Offset: 0x0027B0C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06009A66 RID: 39526 RVA: 0x0027CED4 File Offset: 0x0027B0D4
		// (set) Token: 0x06009A67 RID: 39527 RVA: 0x0027CEE4 File Offset: 0x0027B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BreedId
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

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06009A68 RID: 39528 RVA: 0x0027CEF4 File Offset: 0x0027B0F4
		// (set) Token: 0x06009A69 RID: 39529 RVA: 0x0027CF08 File Offset: 0x0027B108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06009A6A RID: 39530 RVA: 0x0027CF18 File Offset: 0x0027B118
		// (set) Token: 0x06009A6B RID: 39531 RVA: 0x0027CF28 File Offset: 0x0027B128
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook Look
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

		// Token: 0x06009A6C RID: 39532 RVA: 0x0027CF38 File Offset: 0x0027B138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x0027CF48 File Offset: 0x0027B148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterUpdatedBreedEvent other)
		{
			return true;
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x0027CF58 File Offset: 0x0027B158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x0027CF68 File Offset: 0x0027B168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x0027CF78 File Offset: 0x0027B178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x0027CF88 File Offset: 0x0027B188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x0027CF98 File Offset: 0x0027B198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009A73 RID: 39539 RVA: 0x0027CFA8 File Offset: 0x0027B1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterUpdatedBreedEvent other)
		{
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x0027CFB8 File Offset: 0x0027B1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009A75 RID: 39541 RVA: 0x0027CFC8 File Offset: 0x0027B1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x0027CFD8 File Offset: 0x0027B1D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterUpdatedBreedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					CharacterUpdatedBreedEvent._parser = new MessageParser<CharacterUpdatedBreedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x0027D0A4 File Offset: 0x0027B2A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DxjT2BJxdZFC9cftI2m5()
		{
			return true;
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x0027D0AC File Offset: 0x0027B2AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterUpdatedBreedEvent TbSN5HJx9DVAqynFurog()
		{
			return null;
		}

		// Token: 0x04003941 RID: 14657
		private static readonly MessageParser<CharacterUpdatedBreedEvent> _parser;

		// Token: 0x04003942 RID: 14658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003943 RID: 14659
		public const int NameFieldNumber = 1;

		// Token: 0x04003944 RID: 14660
		private string name_;

		// Token: 0x04003945 RID: 14661
		public const int BreedIdFieldNumber = 2;

		// Token: 0x04003946 RID: 14662
		private int breedId_;

		// Token: 0x04003947 RID: 14663
		public const int GenderFieldNumber = 3;

		// Token: 0x04003948 RID: 14664
		private Gender gender_;

		// Token: 0x04003949 RID: 14665
		public const int LookFieldNumber = 4;

		// Token: 0x0400394A RID: 14666
		private EntityLook look_;

		// Token: 0x0400394B RID: 14667
		private static CharacterUpdatedBreedEvent bpwUBHJxsdIOUw0yyrOq;
	}
}
