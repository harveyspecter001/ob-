using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CB3 RID: 3251
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipObjectResponse : IMessage<OutfitEquipObjectResponse>, IMessage, IEquatable<OutfitEquipObjectResponse>, IDeepCloneable<OutfitEquipObjectResponse>, IBufferMessage
	{
		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06009C34 RID: 39988 RVA: 0x002812B0 File Offset: 0x0027F4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OutfitEquipObjectResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06009C35 RID: 39989 RVA: 0x002812C0 File Offset: 0x0027F4C0
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

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x002812D0 File Offset: 0x0027F4D0
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

		// Token: 0x06009C37 RID: 39991 RVA: 0x002812E0 File Offset: 0x0027F4E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectResponse()
		{
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x002812F0 File Offset: 0x0027F4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectResponse(OutfitEquipObjectResponse other)
		{
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x00281300 File Offset: 0x0027F500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipObjectResponse Clone()
		{
			return null;
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x00281310 File Offset: 0x0027F510
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x00281320 File Offset: 0x0027F520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x00281330 File Offset: 0x0027F530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x00281340 File Offset: 0x0027F540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipObjectResponse other)
		{
			return true;
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x00281350 File Offset: 0x0027F550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x00281360 File Offset: 0x0027F560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x00281370 File Offset: 0x0027F570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x00281380 File Offset: 0x0027F580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x00281390 File Offset: 0x0027F590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x002813A0 File Offset: 0x0027F5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipObjectResponse other)
		{
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x002813B0 File Offset: 0x0027F5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x002813C0 File Offset: 0x0027F5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x002813D0 File Offset: 0x0027F5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipObjectResponse()
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
					default:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						return;
					case 2:
						OutfitEquipObjectResponse._parser = new MessageParser<OutfitEquipObjectResponse>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						goto IL_5E;
					}
				}
				IL_5E:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x002814B8 File Offset: 0x0027F6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SKan3DJ4OQiRcnmvOvWi()
		{
			return true;
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x002814C0 File Offset: 0x0027F6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipObjectResponse zOWLs7J4J5fpqmGd3cqx()
		{
			return null;
		}

		// Token: 0x040039F1 RID: 14833
		private static readonly MessageParser<OutfitEquipObjectResponse> _parser;

		// Token: 0x040039F2 RID: 14834
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F3 RID: 14835
		public const int SuccessFieldNumber = 1;

		// Token: 0x040039F4 RID: 14836
		private bool success_;

		// Token: 0x040039F5 RID: 14837
		internal static OutfitEquipObjectResponse zNg0IBJ4R6btctBQb8tn;
	}
}
