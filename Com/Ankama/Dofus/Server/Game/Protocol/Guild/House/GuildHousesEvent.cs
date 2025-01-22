using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.House
{
	// Token: 0x0200052D RID: 1325
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildHousesEvent : IMessage<GuildHousesEvent>, IMessage, IEquatable<GuildHousesEvent>, IDeepCloneable<GuildHousesEvent>, IBufferMessage
	{
		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x001ECE8C File Offset: 0x001EB08C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildHousesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x001ECE9C File Offset: 0x001EB09C
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

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x001ECEAC File Offset: 0x001EB0AC
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

		// Token: 0x06003F9A RID: 16282 RVA: 0x001ECEBC File Offset: 0x001EB0BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHousesEvent()
		{
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x001ECECC File Offset: 0x001EB0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHousesEvent(GuildHousesEvent other)
		{
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x001ECEDC File Offset: 0x001EB0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildHousesEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x001ECEEC File Offset: 0x001EB0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<House> Houses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x001ECEFC File Offset: 0x001EB0FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x001ECF0C File Offset: 0x001EB10C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildHousesEvent other)
		{
			return true;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x001ECF1C File Offset: 0x001EB11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x001ECF2C File Offset: 0x001EB12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x001ECF3C File Offset: 0x001EB13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x001ECF4C File Offset: 0x001EB14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x001ECF5C File Offset: 0x001EB15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x001ECF6C File Offset: 0x001EB16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildHousesEvent other)
		{
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x001ECF7C File Offset: 0x001EB17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x001ECF8C File Offset: 0x001EB18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x001ECF9C File Offset: 0x001EB19C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildHousesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					GuildHousesEvent._parser = new MessageParser<GuildHousesEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					GuildHousesEvent._repeated_houses_codec = FieldCodec.ForMessage<House>(10U, Qlb7XImRf9HtV6bHB6q0.XVInXhlssT(Qlb7XImRf9HtV6bHB6q0.eFnmRnonDuN));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x001ED0A4 File Offset: 0x001EB2A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Brgd4yOpG9KTWIhGGHiN()
		{
			return true;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x001ED0AC File Offset: 0x001EB2AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildHousesEvent Ij0rZAOpg8yvxcQu8jlm()
		{
			return null;
		}

		// Token: 0x04001603 RID: 5635
		private static readonly MessageParser<GuildHousesEvent> _parser;

		// Token: 0x04001604 RID: 5636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001605 RID: 5637
		public const int HousesFieldNumber = 1;

		// Token: 0x04001606 RID: 5638
		private static readonly FieldCodec<House> _repeated_houses_codec;

		// Token: 0x04001607 RID: 5639
		private readonly RepeatedField<House> houses_;

		// Token: 0x04001608 RID: 5640
		internal static GuildHousesEvent DVneudOpJCWb8i8VyBrq;
	}
}
