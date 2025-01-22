using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200057C RID: 1404
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapErrorNotFoundRequest : IMessage<MapErrorNotFoundRequest>, IMessage, IEquatable<MapErrorNotFoundRequest>, IDeepCloneable<MapErrorNotFoundRequest>, IBufferMessage
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x001F539C File Offset: 0x001F359C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapErrorNotFoundRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x001F53AC File Offset: 0x001F35AC
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

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x001F53BC File Offset: 0x001F35BC
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

		// Token: 0x0600439A RID: 17306 RVA: 0x001F53CC File Offset: 0x001F35CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapErrorNotFoundRequest()
		{
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x001F53DC File Offset: 0x001F35DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapErrorNotFoundRequest(MapErrorNotFoundRequest other)
		{
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x001F53EC File Offset: 0x001F35EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapErrorNotFoundRequest Clone()
		{
			return null;
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x001F53FC File Offset: 0x001F35FC
		// (set) Token: 0x0600439E RID: 17310 RVA: 0x001F540C File Offset: 0x001F360C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
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

		// Token: 0x0600439F RID: 17311 RVA: 0x001F541C File Offset: 0x001F361C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x001F542C File Offset: 0x001F362C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapErrorNotFoundRequest other)
		{
			return true;
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x001F543C File Offset: 0x001F363C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x001F544C File Offset: 0x001F364C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x001F545C File Offset: 0x001F365C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x001F546C File Offset: 0x001F366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x001F547C File Offset: 0x001F367C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x001F548C File Offset: 0x001F368C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapErrorNotFoundRequest other)
		{
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x001F549C File Offset: 0x001F369C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x001F54AC File Offset: 0x001F36AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x001F54BC File Offset: 0x001F36BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapErrorNotFoundRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					MapErrorNotFoundRequest._parser = new MessageParser<MapErrorNotFoundRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x001F55B4 File Offset: 0x001F37B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BCGsf4OYfgxaxaeMSi6J()
		{
			return true;
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x001F55BC File Offset: 0x001F37BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapErrorNotFoundRequest SfQf0TOYnqexbHBvVXQ9()
		{
			return null;
		}

		// Token: 0x04001748 RID: 5960
		private static readonly MessageParser<MapErrorNotFoundRequest> _parser;

		// Token: 0x04001749 RID: 5961
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400174A RID: 5962
		public const int MapIdFieldNumber = 1;

		// Token: 0x0400174B RID: 5963
		private int mapId_;

		// Token: 0x0400174C RID: 5964
		internal static MapErrorNotFoundRequest sHDmb0OHzi8N2JOM0OyU;
	}
}
