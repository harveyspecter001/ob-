using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003F2 RID: 1010
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectFeedRequest : IMessage<ObjectFeedRequest>, IMessage, IEquatable<ObjectFeedRequest>, IDeepCloneable<ObjectFeedRequest>, IBufferMessage
	{
		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x001D2CDC File Offset: 0x001D0EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectFeedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x001D2CEC File Offset: 0x001D0EEC
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

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x001D2CFC File Offset: 0x001D0EFC
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

		// Token: 0x06002F9F RID: 12191 RVA: 0x001D2D0C File Offset: 0x001D0F0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFeedRequest()
		{
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x001D2D1C File Offset: 0x001D0F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFeedRequest(ObjectFeedRequest other)
		{
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x001D2D2C File Offset: 0x001D0F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectFeedRequest Clone()
		{
			return null;
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x001D2D3C File Offset: 0x001D0F3C
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x001D2D4C File Offset: 0x001D0F4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x001D2D5C File Offset: 0x001D0F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectUidWithQuantity> Meal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x001D2D6C File Offset: 0x001D0F6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x001D2D7C File Offset: 0x001D0F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectFeedRequest other)
		{
			return true;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x001D2D8C File Offset: 0x001D0F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x001D2D9C File Offset: 0x001D0F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x001D2DAC File Offset: 0x001D0FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x001D2DBC File Offset: 0x001D0FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x001D2DCC File Offset: 0x001D0FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x001D2DDC File Offset: 0x001D0FDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectFeedRequest other)
		{
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x001D2DEC File Offset: 0x001D0FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x001D2DFC File Offset: 0x001D0FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x001D2E0C File Offset: 0x001D100C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectFeedRequest()
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
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					ObjectFeedRequest._parser = new MessageParser<ObjectFeedRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					return;
				}
				ObjectFeedRequest._repeated_meal_codec = FieldCodec.ForMessage<ObjectUidWithQuantity>(18U, s7w74qnuEYuoJcLSH5jI.XVInXhlssT(s7w74qnuEYuoJcLSH5jI.L5AnuXvQxv7));
				num2 = 5;
			}
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x001D2F14 File Offset: 0x001D1114
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dm2aR4O0wLTQ9R1Ax8hB()
		{
			return true;
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x001D2F1C File Offset: 0x001D111C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectFeedRequest XDrePWO0Q2rs9l5GaSAP()
		{
			return null;
		}

		// Token: 0x040010BC RID: 4284
		private static readonly MessageParser<ObjectFeedRequest> _parser;

		// Token: 0x040010BD RID: 4285
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010BE RID: 4286
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x040010BF RID: 4287
		private int objectUid_;

		// Token: 0x040010C0 RID: 4288
		public const int MealFieldNumber = 2;

		// Token: 0x040010C1 RID: 4289
		private static readonly FieldCodec<ObjectUidWithQuantity> _repeated_meal_codec;

		// Token: 0x040010C2 RID: 4290
		private readonly RepeatedField<ObjectUidWithQuantity> meal_;

		// Token: 0x040010C3 RID: 4291
		private static ObjectFeedRequest B5uXdnO0tRAGL6CDsaMa;
	}
}
