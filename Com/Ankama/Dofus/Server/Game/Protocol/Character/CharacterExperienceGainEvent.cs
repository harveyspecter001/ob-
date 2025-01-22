using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008F3 RID: 2291
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterExperienceGainEvent : IMessage<CharacterExperienceGainEvent>, IMessage, IEquatable<CharacterExperienceGainEvent>, IDeepCloneable<CharacterExperienceGainEvent>, IBufferMessage
	{
		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x002389D4 File Offset: 0x00236BD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterExperienceGainEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06006F63 RID: 28515 RVA: 0x002389E4 File Offset: 0x00236BE4
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

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06006F64 RID: 28516 RVA: 0x002389F4 File Offset: 0x00236BF4
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

		// Token: 0x06006F65 RID: 28517 RVA: 0x00238A04 File Offset: 0x00236C04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterExperienceGainEvent()
		{
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x00238A14 File Offset: 0x00236C14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterExperienceGainEvent(CharacterExperienceGainEvent other)
		{
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00238A24 File Offset: 0x00236C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterExperienceGainEvent Clone()
		{
			return null;
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06006F68 RID: 28520 RVA: 0x00238A34 File Offset: 0x00236C34
		// (set) Token: 0x06006F69 RID: 28521 RVA: 0x00238A44 File Offset: 0x00236C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06006F6A RID: 28522 RVA: 0x00238A54 File Offset: 0x00236C54
		// (set) Token: 0x06006F6B RID: 28523 RVA: 0x00238A64 File Offset: 0x00236C64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MountExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06006F6C RID: 28524 RVA: 0x00238A74 File Offset: 0x00236C74
		// (set) Token: 0x06006F6D RID: 28525 RVA: 0x00238A84 File Offset: 0x00236C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GuildExperience
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x00238A94 File Offset: 0x00236C94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00238AA4 File Offset: 0x00236CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterExperienceGainEvent other)
		{
			return true;
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00238AB4 File Offset: 0x00236CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x00238AC4 File Offset: 0x00236CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x00238AD4 File Offset: 0x00236CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x00238AE4 File Offset: 0x00236CE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x00238AF4 File Offset: 0x00236CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x00238B04 File Offset: 0x00236D04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterExperienceGainEvent other)
		{
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x00238B14 File Offset: 0x00236D14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00238B24 File Offset: 0x00236D24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x00238B34 File Offset: 0x00236D34
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterExperienceGainEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterExperienceGainEvent._parser = new MessageParser<CharacterExperienceGainEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x00238C00 File Offset: 0x00236E00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zemgFHJBaWkK6r7QOP9B()
		{
			return true;
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x00238C08 File Offset: 0x00236E08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterExperienceGainEvent z5UgVjJB5CZUYs8sX4GL()
		{
			return null;
		}

		// Token: 0x040026FE RID: 9982
		private static readonly MessageParser<CharacterExperienceGainEvent> _parser;

		// Token: 0x040026FF RID: 9983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002700 RID: 9984
		public const int CharacterExperienceFieldNumber = 1;

		// Token: 0x04002701 RID: 9985
		private long characterExperience_;

		// Token: 0x04002702 RID: 9986
		public const int MountExperienceFieldNumber = 2;

		// Token: 0x04002703 RID: 9987
		private long mountExperience_;

		// Token: 0x04002704 RID: 9988
		public const int GuildExperienceFieldNumber = 3;

		// Token: 0x04002705 RID: 9989
		private long guildExperience_;

		// Token: 0x04002706 RID: 9990
		internal static CharacterExperienceGainEvent n2AhLlJB1NcCt3Ant0ao;
	}
}
