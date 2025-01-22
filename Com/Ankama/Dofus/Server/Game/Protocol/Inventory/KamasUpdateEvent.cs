using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003F9 RID: 1017
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KamasUpdateEvent : IMessage<KamasUpdateEvent>, IMessage, IEquatable<KamasUpdateEvent>, IDeepCloneable<KamasUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x001D316C File Offset: 0x001D136C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<KamasUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x001D317C File Offset: 0x001D137C
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

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x001D318C File Offset: 0x001D138C
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

		// Token: 0x06002FF2 RID: 12274 RVA: 0x001D319C File Offset: 0x001D139C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KamasUpdateEvent()
		{
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x001D31AC File Offset: 0x001D13AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KamasUpdateEvent(KamasUpdateEvent other)
		{
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x001D31BC File Offset: 0x001D13BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KamasUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x001D31CC File Offset: 0x001D13CC
		// (set) Token: 0x06002FF6 RID: 12278 RVA: 0x001D31DC File Offset: 0x001D13DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Quantity
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

		// Token: 0x06002FF7 RID: 12279 RVA: 0x001D31EC File Offset: 0x001D13EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x001D31FC File Offset: 0x001D13FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(KamasUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x001D320C File Offset: 0x001D140C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x001D321C File Offset: 0x001D141C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x001D322C File Offset: 0x001D142C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x001D323C File Offset: 0x001D143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x001D324C File Offset: 0x001D144C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x001D325C File Offset: 0x001D145C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(KamasUpdateEvent other)
		{
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x001D326C File Offset: 0x001D146C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x001D327C File Offset: 0x001D147C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x001D328C File Offset: 0x001D148C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static KamasUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					KamasUpdateEvent._parser = new MessageParser<KamasUpdateEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x001D3358 File Offset: 0x001D1558
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wraJOKO0Y4QMlIRetYAx()
		{
			return true;
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x001D3360 File Offset: 0x001D1560
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KamasUpdateEvent nDJofsO0b6vAUKt59iFM()
		{
			return null;
		}

		// Token: 0x040010D9 RID: 4313
		private static readonly MessageParser<KamasUpdateEvent> _parser;

		// Token: 0x040010DA RID: 4314
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010DB RID: 4315
		public const int QuantityFieldNumber = 1;

		// Token: 0x040010DC RID: 4316
		private long quantity_;

		// Token: 0x040010DD RID: 4317
		internal static KamasUpdateEvent S2rpMMO0HEvPx9CRhIIp;
	}
}
