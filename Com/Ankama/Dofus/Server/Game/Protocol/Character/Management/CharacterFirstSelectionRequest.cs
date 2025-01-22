using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200091F RID: 2335
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterFirstSelectionRequest : IMessage<CharacterFirstSelectionRequest>, IMessage, IEquatable<CharacterFirstSelectionRequest>, IDeepCloneable<CharacterFirstSelectionRequest>, IBufferMessage
	{
		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x0600714C RID: 29004 RVA: 0x0023C594 File Offset: 0x0023A794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterFirstSelectionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x0023C5A4 File Offset: 0x0023A7A4
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

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x0600714E RID: 29006 RVA: 0x0023C5B4 File Offset: 0x0023A7B4
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

		// Token: 0x0600714F RID: 29007 RVA: 0x0023C5C4 File Offset: 0x0023A7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFirstSelectionRequest()
		{
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x0023C5D4 File Offset: 0x0023A7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFirstSelectionRequest(CharacterFirstSelectionRequest other)
		{
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x0023C5E4 File Offset: 0x0023A7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFirstSelectionRequest Clone()
		{
			return null;
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x0023C5F4 File Offset: 0x0023A7F4
		// (set) Token: 0x06007153 RID: 29011 RVA: 0x0023C604 File Offset: 0x0023A804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06007154 RID: 29012 RVA: 0x0023C614 File Offset: 0x0023A814
		// (set) Token: 0x06007155 RID: 29013 RVA: 0x0023C624 File Offset: 0x0023A824
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool DoTutorial
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x0023C634 File Offset: 0x0023A834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x0023C644 File Offset: 0x0023A844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterFirstSelectionRequest other)
		{
			return true;
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x0023C654 File Offset: 0x0023A854
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x0023C664 File Offset: 0x0023A864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x0023C674 File Offset: 0x0023A874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x0023C684 File Offset: 0x0023A884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x0023C694 File Offset: 0x0023A894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x0023C6A4 File Offset: 0x0023A8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterFirstSelectionRequest other)
		{
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x0023C6B4 File Offset: 0x0023A8B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x0023C6C4 File Offset: 0x0023A8C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x0023C6D4 File Offset: 0x0023A8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterFirstSelectionRequest()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				CharacterFirstSelectionRequest._parser = new MessageParser<CharacterFirstSelectionRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x0023C7B8 File Offset: 0x0023A9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B5c8lxJeo9pFuuRecmle()
		{
			return true;
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x0023C7C0 File Offset: 0x0023A9C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterFirstSelectionRequest EEr4tWJe1k62AGnNUV8V()
		{
			return null;
		}

		// Token: 0x040027AA RID: 10154
		private static readonly MessageParser<CharacterFirstSelectionRequest> _parser;

		// Token: 0x040027AB RID: 10155
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027AC RID: 10156
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x040027AD RID: 10157
		private long characterId_;

		// Token: 0x040027AE RID: 10158
		public const int DoTutorialFieldNumber = 2;

		// Token: 0x040027AF RID: 10159
		private bool doTutorial_;

		// Token: 0x040027B0 RID: 10160
		internal static CharacterFirstSelectionRequest BwcT2JJevUVx5WLrVYVM;
	}
}
