using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote
{
	// Token: 0x020007C5 RID: 1989
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EmotePlayErrorEvent : IMessage<EmotePlayErrorEvent>, IMessage, IEquatable<EmotePlayErrorEvent>, IDeepCloneable<EmotePlayErrorEvent>, IBufferMessage
	{
		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06006181 RID: 24961 RVA: 0x002210C8 File Offset: 0x0021F2C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<EmotePlayErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x002210D8 File Offset: 0x0021F2D8
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

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06006183 RID: 24963 RVA: 0x002210E8 File Offset: 0x0021F2E8
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

		// Token: 0x06006184 RID: 24964 RVA: 0x002210F8 File Offset: 0x0021F2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayErrorEvent()
		{
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x00221108 File Offset: 0x0021F308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayErrorEvent(EmotePlayErrorEvent other)
		{
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x00221118 File Offset: 0x0021F318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotePlayErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06006187 RID: 24967 RVA: 0x00221128 File Offset: 0x0021F328
		// (set) Token: 0x06006188 RID: 24968 RVA: 0x00221138 File Offset: 0x0021F338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int EmoteId
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

		// Token: 0x06006189 RID: 24969 RVA: 0x00221148 File Offset: 0x0021F348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x00221158 File Offset: 0x0021F358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(EmotePlayErrorEvent other)
		{
			return true;
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x00221168 File Offset: 0x0021F368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x00221178 File Offset: 0x0021F378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x00221188 File Offset: 0x0021F388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x00221198 File Offset: 0x0021F398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x002211A8 File Offset: 0x0021F3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x002211B8 File Offset: 0x0021F3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(EmotePlayErrorEvent other)
		{
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x002211C8 File Offset: 0x0021F3C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x002211D8 File Offset: 0x0021F3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x002211E8 File Offset: 0x0021F3E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static EmotePlayErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_5F;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 4:
						EmotePlayErrorEvent._parser = new MessageParser<EmotePlayErrorEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_5F:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x002212D0 File Offset: 0x0021F4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bUq8uKOFGM6qHbhnMlOh()
		{
			return true;
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x002212D8 File Offset: 0x0021F4D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EmotePlayErrorEvent em7kfsOFgvrtsO1mSxH4()
		{
			return null;
		}

		// Token: 0x04002246 RID: 8774
		private static readonly MessageParser<EmotePlayErrorEvent> _parser;

		// Token: 0x04002247 RID: 8775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002248 RID: 8776
		public const int EmoteIdFieldNumber = 1;

		// Token: 0x04002249 RID: 8777
		private int emoteId_;

		// Token: 0x0400224A RID: 8778
		private static EmotePlayErrorEvent kgxsZkOFJNQ5JR2yg5gl;
	}
}
