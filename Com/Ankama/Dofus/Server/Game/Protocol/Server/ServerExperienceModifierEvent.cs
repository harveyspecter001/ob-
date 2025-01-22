using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Server
{
	// Token: 0x0200016A RID: 362
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerExperienceModifierEvent : IMessage<ServerExperienceModifierEvent>, IMessage, IEquatable<ServerExperienceModifierEvent>, IDeepCloneable<ServerExperienceModifierEvent>, IBufferMessage
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x0019E8F4 File Offset: 0x0019CAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerExperienceModifierEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0019E904 File Offset: 0x0019CB04
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0019E914 File Offset: 0x0019CB14
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

		// Token: 0x06001097 RID: 4247 RVA: 0x0019E924 File Offset: 0x0019CB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerExperienceModifierEvent()
		{
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0019E934 File Offset: 0x0019CB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerExperienceModifierEvent(ServerExperienceModifierEvent other)
		{
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0019E944 File Offset: 0x0019CB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerExperienceModifierEvent Clone()
		{
			return null;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0019E954 File Offset: 0x0019CB54
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x0019E964 File Offset: 0x0019CB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExperiencePercentage
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

		// Token: 0x0600109C RID: 4252 RVA: 0x0019E974 File Offset: 0x0019CB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0019E984 File Offset: 0x0019CB84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerExperienceModifierEvent other)
		{
			return true;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0019E994 File Offset: 0x0019CB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0019E9A4 File Offset: 0x0019CBA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0019E9B4 File Offset: 0x0019CBB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0019E9C4 File Offset: 0x0019CBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0019E9D4 File Offset: 0x0019CBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0019E9E4 File Offset: 0x0019CBE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerExperienceModifierEvent other)
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0019E9F4 File Offset: 0x0019CBF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0019EA04 File Offset: 0x0019CC04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0019EA14 File Offset: 0x0019CC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerExperienceModifierEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					ServerExperienceModifierEvent._parser = new MessageParser<ServerExperienceModifierEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0019EB0C File Offset: 0x0019CD0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mmdPLYOUZy6gppmBpCit()
		{
			return true;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0019EB14 File Offset: 0x0019CD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerExperienceModifierEvent MBjKVUOUqmpX7etiGjut()
		{
			return null;
		}

		// Token: 0x0400060C RID: 1548
		private static readonly MessageParser<ServerExperienceModifierEvent> _parser;

		// Token: 0x0400060D RID: 1549
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400060E RID: 1550
		public const int ExperiencePercentageFieldNumber = 1;

		// Token: 0x0400060F RID: 1551
		private int experiencePercentage_;

		// Token: 0x04000610 RID: 1552
		internal static ServerExperienceModifierEvent aY2Fg3OU87CymBo01di4;
	}
}
