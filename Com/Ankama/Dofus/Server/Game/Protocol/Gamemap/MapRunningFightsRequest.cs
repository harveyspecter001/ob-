using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000580 RID: 1408
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapRunningFightsRequest : IMessage<MapRunningFightsRequest>, IMessage, IEquatable<MapRunningFightsRequest>, IDeepCloneable<MapRunningFightsRequest>, IBufferMessage
	{
		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x001F580C File Offset: 0x001F3A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapRunningFightsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060043CE RID: 17358 RVA: 0x001F581C File Offset: 0x001F3A1C
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

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x001F582C File Offset: 0x001F3A2C
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

		// Token: 0x060043D0 RID: 17360 RVA: 0x001F583C File Offset: 0x001F3A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightsRequest()
		{
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x001F584C File Offset: 0x001F3A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightsRequest(MapRunningFightsRequest other)
		{
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x001F585C File Offset: 0x001F3A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightsRequest Clone()
		{
			return null;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x001F586C File Offset: 0x001F3A6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x001F587C File Offset: 0x001F3A7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapRunningFightsRequest other)
		{
			return true;
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x001F588C File Offset: 0x001F3A8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x001F589C File Offset: 0x001F3A9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x001F58AC File Offset: 0x001F3AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x001F58BC File Offset: 0x001F3ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x001F58CC File Offset: 0x001F3ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x001F58DC File Offset: 0x001F3ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapRunningFightsRequest other)
		{
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x001F58EC File Offset: 0x001F3AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x001F58FC File Offset: 0x001F3AFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x001F590C File Offset: 0x001F3B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapRunningFightsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_98;
					case 4:
						MapRunningFightsRequest._parser = new MessageParser<MapRunningFightsRequest>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
				}
				IL_98:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x001F59DC File Offset: 0x001F3BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eEiMIJOY3qn3jdtHiSIi()
		{
			return true;
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x001F59E4 File Offset: 0x001F3BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapRunningFightsRequest rRbpbFOYRexurw2VxYm1()
		{
			return null;
		}

		// Token: 0x04001758 RID: 5976
		private static readonly MessageParser<MapRunningFightsRequest> _parser;

		// Token: 0x04001759 RID: 5977
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400175A RID: 5978
		private static MapRunningFightsRequest X6St1uOYeE3F2LfJ6wV3;
	}
}
