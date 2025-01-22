using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x0200034B RID: 843
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayAnimationOnNpcEvent : IMessage<PlayAnimationOnNpcEvent>, IMessage, IEquatable<PlayAnimationOnNpcEvent>, IDeepCloneable<PlayAnimationOnNpcEvent>, IBufferMessage
	{
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x001C4068 File Offset: 0x001C2268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayAnimationOnNpcEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x001C4078 File Offset: 0x001C2278
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

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x001C4088 File Offset: 0x001C2288
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

		// Token: 0x06002792 RID: 10130 RVA: 0x001C4098 File Offset: 0x001C2298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayAnimationOnNpcEvent()
		{
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x001C40A8 File Offset: 0x001C22A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayAnimationOnNpcEvent(PlayAnimationOnNpcEvent other)
		{
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x001C40B8 File Offset: 0x001C22B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayAnimationOnNpcEvent Clone()
		{
			return null;
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x001C40C8 File Offset: 0x001C22C8
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x001C40D8 File Offset: 0x001C22D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcId
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

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x001C40E8 File Offset: 0x001C22E8
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x001C40F8 File Offset: 0x001C22F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Animation
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

		// Token: 0x06002799 RID: 10137 RVA: 0x001C4108 File Offset: 0x001C2308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x001C4118 File Offset: 0x001C2318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayAnimationOnNpcEvent other)
		{
			return true;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x001C4128 File Offset: 0x001C2328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x001C4138 File Offset: 0x001C2338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x001C4148 File Offset: 0x001C2348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x001C4158 File Offset: 0x001C2358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x001C4168 File Offset: 0x001C2368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x001C4178 File Offset: 0x001C2378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayAnimationOnNpcEvent other)
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x001C4188 File Offset: 0x001C2388
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x001C4198 File Offset: 0x001C2398
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x001C41A8 File Offset: 0x001C23A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayAnimationOnNpcEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					PlayAnimationOnNpcEvent._parser = new MessageParser<PlayAnimationOnNpcEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x001C428C File Offset: 0x001C248C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qPsM5hOhg9iqeyKxgoNQ()
		{
			return true;
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x001C4294 File Offset: 0x001C2494
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayAnimationOnNpcEvent VrXgpROhsJbgA2kdcgBN()
		{
			return null;
		}

		// Token: 0x04000E1A RID: 3610
		private static readonly MessageParser<PlayAnimationOnNpcEvent> _parser;

		// Token: 0x04000E1B RID: 3611
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E1C RID: 3612
		public const int NpcIdFieldNumber = 1;

		// Token: 0x04000E1D RID: 3613
		private int npcId_;

		// Token: 0x04000E1E RID: 3614
		public const int AnimationFieldNumber = 2;

		// Token: 0x04000E1F RID: 3615
		private string animation_;

		// Token: 0x04000E20 RID: 3616
		private static PlayAnimationOnNpcEvent TE8fEyOhGnVROwZb8BN2;
	}
}
