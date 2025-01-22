using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000403 RID: 1027
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectMovementEvent : IMessage<ObjectMovementEvent>, IMessage, IEquatable<ObjectMovementEvent>, IDeepCloneable<ObjectMovementEvent>, IBufferMessage
	{
		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x001D3BF4 File Offset: 0x001D1DF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectMovementEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x001D3C04 File Offset: 0x001D1E04
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

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x001D3C14 File Offset: 0x001D1E14
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

		// Token: 0x06003072 RID: 12402 RVA: 0x001D3C24 File Offset: 0x001D1E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectMovementEvent()
		{
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x001D3C34 File Offset: 0x001D1E34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectMovementEvent(ObjectMovementEvent other)
		{
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x001D3C44 File Offset: 0x001D1E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectMovementEvent Clone()
		{
			return null;
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x001D3C54 File Offset: 0x001D1E54
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x001D3C64 File Offset: 0x001D1E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
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

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x001D3C74 File Offset: 0x001D1E74
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x001D3C84 File Offset: 0x001D1E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Position
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

		// Token: 0x06003079 RID: 12409 RVA: 0x001D3C94 File Offset: 0x001D1E94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x001D3CA4 File Offset: 0x001D1EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectMovementEvent other)
		{
			return true;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x001D3CB4 File Offset: 0x001D1EB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x001D3CC4 File Offset: 0x001D1EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x001D3CD4 File Offset: 0x001D1ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x001D3CE4 File Offset: 0x001D1EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x001D3CF4 File Offset: 0x001D1EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x001D3D04 File Offset: 0x001D1F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectMovementEvent other)
		{
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x001D3D14 File Offset: 0x001D1F14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x001D3D24 File Offset: 0x001D1F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x001D3D34 File Offset: 0x001D1F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectMovementEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					ObjectMovementEvent._parser = new MessageParser<ObjectMovementEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x001D3E18 File Offset: 0x001D2018
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zIaqBQOCAoKynSeVEZuP()
		{
			return true;
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x001D3E20 File Offset: 0x001D2020
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectMovementEvent oYaiygOCB9Kh3elmBK5p()
		{
			return null;
		}

		// Token: 0x040010FE RID: 4350
		private static readonly MessageParser<ObjectMovementEvent> _parser;

		// Token: 0x040010FF RID: 4351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001100 RID: 4352
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001101 RID: 4353
		private int objectUid_;

		// Token: 0x04001102 RID: 4354
		public const int PositionFieldNumber = 2;

		// Token: 0x04001103 RID: 4355
		private int position_;

		// Token: 0x04001104 RID: 4356
		internal static ObjectMovementEvent xFa2bJOCmxkOMH6WypAC;
	}
}
