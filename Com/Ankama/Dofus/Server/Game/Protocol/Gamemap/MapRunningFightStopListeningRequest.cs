using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000582 RID: 1410
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapRunningFightStopListeningRequest : IMessage<MapRunningFightStopListeningRequest>, IMessage, IEquatable<MapRunningFightStopListeningRequest>, IDeepCloneable<MapRunningFightStopListeningRequest>, IBufferMessage
	{
		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x001F59EC File Offset: 0x001F3BEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapRunningFightStopListeningRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x001F59FC File Offset: 0x001F3BFC
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

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x001F5A0C File Offset: 0x001F3C0C
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

		// Token: 0x060043E8 RID: 17384 RVA: 0x001F5A1C File Offset: 0x001F3C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightStopListeningRequest()
		{
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x001F5A2C File Offset: 0x001F3C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightStopListeningRequest(MapRunningFightStopListeningRequest other)
		{
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x001F5A3C File Offset: 0x001F3C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightStopListeningRequest Clone()
		{
			return null;
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x001F5A4C File Offset: 0x001F3C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x001F5A5C File Offset: 0x001F3C5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapRunningFightStopListeningRequest other)
		{
			return true;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x001F5A6C File Offset: 0x001F3C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x001F5A7C File Offset: 0x001F3C7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x001F5A8C File Offset: 0x001F3C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x001F5A9C File Offset: 0x001F3C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x001F5AAC File Offset: 0x001F3CAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x001F5ABC File Offset: 0x001F3CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapRunningFightStopListeningRequest other)
		{
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x001F5ACC File Offset: 0x001F3CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x001F5ADC File Offset: 0x001F3CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x001F5AEC File Offset: 0x001F3CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapRunningFightStopListeningRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 3:
						goto IL_C0;
					case 4:
						MapRunningFightStopListeningRequest._parser = new MessageParser<MapRunningFightStopListeningRequest>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_C0:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x001F5BD4 File Offset: 0x001F3DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kew2RiOYJDvfmq0eCu0U()
		{
			return true;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x001F5BDC File Offset: 0x001F3DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapRunningFightStopListeningRequest gZ0qqyOYGNHcGtlChLrr()
		{
			return null;
		}

		// Token: 0x0400175D RID: 5981
		private static readonly MessageParser<MapRunningFightStopListeningRequest> _parser;

		// Token: 0x0400175E RID: 5982
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400175F RID: 5983
		internal static MapRunningFightStopListeningRequest E6yMLfOYO1JeZtQaItj4;
	}
}
