using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000915 RID: 2325
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterReplayWithRemodelRequest : IMessage<CharacterReplayWithRemodelRequest>, IMessage, IEquatable<CharacterReplayWithRemodelRequest>, IDeepCloneable<CharacterReplayWithRemodelRequest>, IBufferMessage
	{
		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x060070CA RID: 28874 RVA: 0x0023BB84 File Offset: 0x00239D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterReplayWithRemodelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x060070CB RID: 28875 RVA: 0x0023BB94 File Offset: 0x00239D94
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

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060070CC RID: 28876 RVA: 0x0023BBA4 File Offset: 0x00239DA4
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

		// Token: 0x060070CD RID: 28877 RVA: 0x0023BBB4 File Offset: 0x00239DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterReplayWithRemodelRequest()
		{
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x0023BBC4 File Offset: 0x00239DC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterReplayWithRemodelRequest(CharacterReplayWithRemodelRequest other)
		{
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x0023BBD4 File Offset: 0x00239DD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterReplayWithRemodelRequest Clone()
		{
			return null;
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060070D0 RID: 28880 RVA: 0x0023BBE4 File Offset: 0x00239DE4
		// (set) Token: 0x060070D1 RID: 28881 RVA: 0x0023BBF4 File Offset: 0x00239DF4
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

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x060070D2 RID: 28882 RVA: 0x0023BC04 File Offset: 0x00239E04
		// (set) Token: 0x060070D3 RID: 28883 RVA: 0x0023BC14 File Offset: 0x00239E14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character RemodelingInformation
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

		// Token: 0x060070D4 RID: 28884 RVA: 0x0023BC24 File Offset: 0x00239E24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x0023BC34 File Offset: 0x00239E34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterReplayWithRemodelRequest other)
		{
			return true;
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x0023BC44 File Offset: 0x00239E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x0023BC54 File Offset: 0x00239E54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x0023BC64 File Offset: 0x00239E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x0023BC74 File Offset: 0x00239E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x0023BC84 File Offset: 0x00239E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x0023BC94 File Offset: 0x00239E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterReplayWithRemodelRequest other)
		{
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x0023BCA4 File Offset: 0x00239EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x0023BCB4 File Offset: 0x00239EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x0023BCC4 File Offset: 0x00239EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterReplayWithRemodelRequest()
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
						CharacterReplayWithRemodelRequest._parser = new MessageParser<CharacterReplayWithRemodelRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						continue;
					case 4:
						goto IL_49;
					}
					return;
				}
				IL_49:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x0023BD94 File Offset: 0x00239F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fixEcYJe9oRB77dPO20f()
		{
			return true;
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x0023BD9C File Offset: 0x00239F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterReplayWithRemodelRequest wJ4EhuJe25kxWP7Qpttl()
		{
			return null;
		}

		// Token: 0x04002787 RID: 10119
		private static readonly MessageParser<CharacterReplayWithRemodelRequest> _parser;

		// Token: 0x04002788 RID: 10120
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002789 RID: 10121
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400278A RID: 10122
		private long characterId_;

		// Token: 0x0400278B RID: 10123
		public const int RemodelingInformationFieldNumber = 2;

		// Token: 0x0400278C RID: 10124
		private Character remodelingInformation_;

		// Token: 0x0400278D RID: 10125
		internal static CharacterReplayWithRemodelRequest xdAR8rJedBxnCjcN4OWj;
	}
}
