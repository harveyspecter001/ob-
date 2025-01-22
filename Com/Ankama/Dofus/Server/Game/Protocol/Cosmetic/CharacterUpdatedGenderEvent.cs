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
	// Token: 0x02000C89 RID: 3209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterUpdatedGenderEvent : IMessage<CharacterUpdatedGenderEvent>, IMessage, IEquatable<CharacterUpdatedGenderEvent>, IDeepCloneable<CharacterUpdatedGenderEvent>, IBufferMessage
	{
		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x0027C92C File Offset: 0x0027AB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterUpdatedGenderEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06009A20 RID: 39456 RVA: 0x0027C93C File Offset: 0x0027AB3C
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

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06009A21 RID: 39457 RVA: 0x0027C94C File Offset: 0x0027AB4C
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

		// Token: 0x06009A22 RID: 39458 RVA: 0x0027C95C File Offset: 0x0027AB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedGenderEvent()
		{
		}

		// Token: 0x06009A23 RID: 39459 RVA: 0x0027C96C File Offset: 0x0027AB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedGenderEvent(CharacterUpdatedGenderEvent other)
		{
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x0027C97C File Offset: 0x0027AB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdatedGenderEvent Clone()
		{
			return null;
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06009A25 RID: 39461 RVA: 0x0027C98C File Offset: 0x0027AB8C
		// (set) Token: 0x06009A26 RID: 39462 RVA: 0x0027C99C File Offset: 0x0027AB9C
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

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06009A27 RID: 39463 RVA: 0x0027C9AC File Offset: 0x0027ABAC
		// (set) Token: 0x06009A28 RID: 39464 RVA: 0x0027C9C0 File Offset: 0x0027ABC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06009A29 RID: 39465 RVA: 0x0027C9D0 File Offset: 0x0027ABD0
		// (set) Token: 0x06009A2A RID: 39466 RVA: 0x0027C9E0 File Offset: 0x0027ABE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06009A2B RID: 39467 RVA: 0x0027C9F0 File Offset: 0x0027ABF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x0027CA00 File Offset: 0x0027AC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterUpdatedGenderEvent other)
		{
			return true;
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x0027CA10 File Offset: 0x0027AC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x0027CA20 File Offset: 0x0027AC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x0027CA30 File Offset: 0x0027AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x0027CA40 File Offset: 0x0027AC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x0027CA50 File Offset: 0x0027AC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x0027CA60 File Offset: 0x0027AC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterUpdatedGenderEvent other)
		{
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x0027CA70 File Offset: 0x0027AC70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x0027CA80 File Offset: 0x0027AC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009A35 RID: 39477 RVA: 0x0027CA90 File Offset: 0x0027AC90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterUpdatedGenderEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterUpdatedGenderEvent._parser = new MessageParser<CharacterUpdatedGenderEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x0027CB88 File Offset: 0x0027AD88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zg8952JxRaXoUMHLAtkh()
		{
			return true;
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x0027CB90 File Offset: 0x0027AD90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterUpdatedGenderEvent h5YfNEJxOZLc0qj5rWCc()
		{
			return null;
		}

		// Token: 0x04003926 RID: 14630
		private static readonly MessageParser<CharacterUpdatedGenderEvent> _parser;

		// Token: 0x04003927 RID: 14631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003928 RID: 14632
		public const int NameFieldNumber = 1;

		// Token: 0x04003929 RID: 14633
		private string name_;

		// Token: 0x0400392A RID: 14634
		public const int GenderFieldNumber = 2;

		// Token: 0x0400392B RID: 14635
		private Gender gender_;

		// Token: 0x0400392C RID: 14636
		public const int LookFieldNumber = 3;

		// Token: 0x0400392D RID: 14637
		private EntityLook look_;

		// Token: 0x0400392E RID: 14638
		internal static CharacterUpdatedGenderEvent v7q6wiJx3e1Op4owT95C;
	}
}
