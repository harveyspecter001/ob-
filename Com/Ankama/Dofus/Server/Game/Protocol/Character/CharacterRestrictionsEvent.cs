using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x02000903 RID: 2307
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterRestrictionsEvent : IMessage<CharacterRestrictionsEvent>, IMessage, IEquatable<CharacterRestrictionsEvent>, IDeepCloneable<CharacterRestrictionsEvent>, IBufferMessage
	{
		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x002396CC File Offset: 0x002378CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterRestrictionsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600700D RID: 28685 RVA: 0x002396DC File Offset: 0x002378DC
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

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x0600700E RID: 28686 RVA: 0x002396EC File Offset: 0x002378EC
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

		// Token: 0x0600700F RID: 28687 RVA: 0x002396FC File Offset: 0x002378FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRestrictionsEvent()
		{
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x0023970C File Offset: 0x0023790C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRestrictionsEvent(CharacterRestrictionsEvent other)
		{
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x0023971C File Offset: 0x0023791C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRestrictionsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06007012 RID: 28690 RVA: 0x0023972C File Offset: 0x0023792C
		// (set) Token: 0x06007013 RID: 28691 RVA: 0x0023973C File Offset: 0x0023793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterId
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

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x0023974C File Offset: 0x0023794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Restriction> Restrictions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x0023975C File Offset: 0x0023795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x0023976C File Offset: 0x0023796C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterRestrictionsEvent other)
		{
			return true;
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x0023977C File Offset: 0x0023797C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x0023978C File Offset: 0x0023798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007019 RID: 28697 RVA: 0x0023979C File Offset: 0x0023799C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600701A RID: 28698 RVA: 0x002397AC File Offset: 0x002379AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600701B RID: 28699 RVA: 0x002397BC File Offset: 0x002379BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x002397CC File Offset: 0x002379CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterRestrictionsEvent other)
		{
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x002397DC File Offset: 0x002379DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600701E RID: 28702 RVA: 0x002397EC File Offset: 0x002379EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x002397FC File Offset: 0x002379FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterRestrictionsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						CharacterRestrictionsEvent._parser = new MessageParser<CharacterRestrictionsEvent>(() => null);
						num2 = 2;
						break;
					case 2:
						CharacterRestrictionsEvent._repeated_restrictions_codec = FieldCodec.ForEnum<Restriction>(18U, (Restriction x) => 0, (int x) => (Restriction)null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
						{
							num2 = 3;
						}
						break;
					case 5:
						goto IL_AE;
					}
				}
				IL_AE:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 4;
			}
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x0023991C File Offset: 0x00237B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w9M9ykJBHbyFltWhBFoq()
		{
			return true;
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x00239924 File Offset: 0x00237B24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterRestrictionsEvent sFcTjqJBYmsTRfkt8clR()
		{
			return null;
		}

		// Token: 0x0400273E RID: 10046
		private static readonly MessageParser<CharacterRestrictionsEvent> _parser;

		// Token: 0x0400273F RID: 10047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002740 RID: 10048
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002741 RID: 10049
		private long characterId_;

		// Token: 0x04002742 RID: 10050
		public const int RestrictionsFieldNumber = 2;

		// Token: 0x04002743 RID: 10051
		private static readonly FieldCodec<Restriction> _repeated_restrictions_codec;

		// Token: 0x04002744 RID: 10052
		private readonly RepeatedField<Restriction> restrictions_;

		// Token: 0x04002745 RID: 10053
		internal static CharacterRestrictionsEvent WjLMOxJBpcx7jZB0tLEe;
	}
}
