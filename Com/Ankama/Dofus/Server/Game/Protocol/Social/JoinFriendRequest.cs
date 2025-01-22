using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000146 RID: 326
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JoinFriendRequest : IMessage<JoinFriendRequest>, IMessage, IEquatable<JoinFriendRequest>, IDeepCloneable<JoinFriendRequest>, IBufferMessage
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0019C2B8 File Offset: 0x0019A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JoinFriendRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0019C2C8 File Offset: 0x0019A4C8
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0019C2D8 File Offset: 0x0019A4D8
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

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0019C2E8 File Offset: 0x0019A4E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JoinFriendRequest()
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0019C2F8 File Offset: 0x0019A4F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JoinFriendRequest(JoinFriendRequest other)
		{
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0019C308 File Offset: 0x0019A508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JoinFriendRequest Clone()
		{
			return null;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0019C318 File Offset: 0x0019A518
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x0019C328 File Offset: 0x0019A528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ActorId
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

		// Token: 0x06000EEE RID: 3822 RVA: 0x0019C338 File Offset: 0x0019A538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0019C348 File Offset: 0x0019A548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JoinFriendRequest other)
		{
			return true;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0019C358 File Offset: 0x0019A558
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0019C368 File Offset: 0x0019A568
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0019C378 File Offset: 0x0019A578
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0019C388 File Offset: 0x0019A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0019C398 File Offset: 0x0019A598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0019C3A8 File Offset: 0x0019A5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JoinFriendRequest other)
		{
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0019C3B8 File Offset: 0x0019A5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0019C3C8 File Offset: 0x0019A5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0019C3D8 File Offset: 0x0019A5D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JoinFriendRequest()
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
						JoinFriendRequest._parser = new MessageParser<JoinFriendRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						goto IL_98;
					}
					return;
				}
				IL_98:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0019C4C0 File Offset: 0x0019A6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IPEcQnOUdu8ZVd95MCT8()
		{
			return true;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0019C4C8 File Offset: 0x0019A6C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JoinFriendRequest QYsMhPOU96KgdnTMNg3o()
		{
			return null;
		}

		// Token: 0x04000578 RID: 1400
		private static readonly MessageParser<JoinFriendRequest> _parser;

		// Token: 0x04000579 RID: 1401
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400057A RID: 1402
		public const int ActorIdFieldNumber = 1;

		// Token: 0x0400057B RID: 1403
		private long actorId_;

		// Token: 0x0400057C RID: 1404
		internal static JoinFriendRequest JEMAdCOUsDWsxMi9HGlK;
	}
}
